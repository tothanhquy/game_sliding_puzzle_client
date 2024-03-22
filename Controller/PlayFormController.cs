using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game_sliding_puzzle.View;
using game_sliding_puzzle.API;
using Newtonsoft.Json;
using System.Threading;

namespace game_sliding_puzzle.Controller
{
    public class PlayFormController : Controller
    {
        private PlayFormView view;
        private Router router;
        private int level;
        private long timeStart = 0;
        private long timeMinus = 0;
        private bool isPausing;
        private bool IsPausing
        {
            set
            {
                view.isPausing = value;
                this.isPausing = value;
            }
            get
            {
                return this.isPausing;
            }
        }
        const int WIDTH_BIG_IMAGE = 450;
        private Image playImage = null;

        private Thread threadTime;

        DataForPlayForm dataForPlayForm;

        public PlayFormController(Router router, DataForPlayForm dataForPlayForm) : base()
        {
            this.view = new PlayFormView(this);
            view.victoryFlag = false;
            this.router = router;

            Control.CheckForIllegalCrossThreadCalls = false;
            threadTime = new Thread(new ThreadStart(threadLoadingFunction));
            threadTime.Start();

            this.dataForPlayForm = dataForPlayForm;
            IsPausing = true;
            view.isLoading = true;
            view.pauseAble = false;
            view.ShowDialog();

            
        }
        public void formLoad()
        {
            if (dataForPlayForm.continuePreviousGame == true)
            {
                continuePreviousGame();
            }
            else
            {
                startNewGame(dataForPlayForm.level);
            }
            IsPausing = false;

            view.isLoading = false;
            view.pauseAble = true;
        }

        private void threadLoadingFunction()
        {
            while (true)
            {
                if (view.victoryFlag) break;
                if(!IsPausing&& !view.isLoading)
                    view.TimeSec = int.Parse(""+Math.Floor(Convert.ToDecimal((float)(getTimeNow() - timeStart - timeMinus)/1000)));
                Thread.Sleep(1000);
            }
        
        }

        #region key press
        private string getMoveStartStatus(Keys e)
        {
            if (e == Keys.Up) return "up";
            if (e == Keys.Left) return "left";
            if (e == Keys.Right) return "right";
            return "down";
        }
        public void move(Keys e)
        {
            if (view.victoryFlag) return;
            if (IsPausing) return;
            if (view.isLoading) return;

            try
            {
                API.API api = new API.API();
                string rememberUser = "";
                string rememberAccessToken = "";
                string moveStatus = getMoveStartStatus(e);
                if (this.getCookie(ref rememberUser, ref rememberAccessToken) == false)
                {
                    //not remember
                    MessageBox.Show("Bạn đã bị đăng xuất");
                    router.LoginFormControllerFlag = true;
                    view.Close();
                    return;
                }
                else
                {

                    string stringParams =
                        "rememberUserName=" + api.urlEndcode(rememberUser) +
                        "&rememberAccessToken=" + api.urlEndcode(rememberAccessToken) +
                        "&moveStatus=" + api.urlEndcode(moveStatus);
                    string resServerString = api.requestServer("/game/move", stringParams);
                    
                    dynamic resServer = JsonConvert.DeserializeObject(resServerString);

                    if (resServer.code == -1)
                    {
                        //error
                        if (resServer.error == "not_login")
                        {
                            MessageBox.Show("Bạn đã bị đăng xuất");
                            router.LoginFormControllerFlag = true;
                            view.Close();
                            return;
                        }
                        else if (resServer.error == "error")
                        {
                            MessageBox.Show("Lỗi hệ thống!");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Lỗi hệ thống!");
                            return;
                        }
                    }
                    else
                    {
                        //succes
                        int[] matrix = resServer.data.matrix.ToObject<int[]>();

                        view.updateImageItemsIndex(matrix);
                        view.changeImageItemPosition();
                        if (resServer.data.isWin == true)
                        {
                            //win
                            winGame();
                        }
                        else
                        {
                            // continue play
                        }
                        
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi hệ thống!");
                return;
            }

        }
        #endregion
        
        private void continuePreviousGame()
        {
            try
            {
                API.API api = new API.API();
                string rememberUser = "";
                string rememberAccessToken = "";
                if (this.getCookie(ref rememberUser, ref rememberAccessToken) == false)
                {
                    //not remember
                    MessageBox.Show("Bạn đã bị đăng xuất");
                    router.LoginFormControllerFlag = true;
                    view.Close();
                    return;
                }
                else
                {

                    string stringParams = "rememberUserName=" + api.urlEndcode(rememberUser) + "&rememberAccessToken=" + api.urlEndcode(rememberAccessToken);
                    string resServerString = api.requestServer("/game/load", stringParams);
                   
                    dynamic resServer = JsonConvert.DeserializeObject(resServerString);

                    if (resServer.code == -1)
                    {
                        //error
                        if (resServer.error == "not_login")
                        {
                            MessageBox.Show("Bạn đã bị đăng xuất");
                            router.LoginFormControllerFlag = true;
                            view.Close();
                            return;
                        }
                        else if (resServer.error == "error")
                        {
                            MessageBox.Show("Lỗi hệ thống!");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Lỗi hệ thống!");
                            return;
                        }
                    }
                    else
                    {
                        //succes
                        this.level = resServer.data.level;
                        view.level = this.level;
                        view.widthImageItem = WIDTH_BIG_IMAGE / this.level;

                        
                        string pathSaveImage = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                        pathSaveImage += @"\image\playing_images\" + resServer.data.imageName;

                        if (
                            playImage==null&&
                            !File.Exists(pathSaveImage)&&
                            api.downloadImage("/static/images/" + resServer.data.imageName, pathSaveImage) == false)
                        {
                            throw new Exception("error download image");
                        }
                        else
                        {
                            if(playImage == null)
                            {
                                Image image = getImageFromPath(pathSaveImage);
                                this.playImage = image;
                                view.imageItems = getImageItems(image);
                                view.setImageControls();
                            }

                            int[] matrix = resServer.data.matrix.ToObject<int[]>();

                            view.updateImageItemsIndex(matrix);

                            //set time
                            this.timeStart = resServer.data.timeStart;
                            this.timeMinus = resServer.data.timeMinus;
                           
                            view.changeImageItemPosition();
                            
                            view.setSmallImage(level > 3 ? playImage : null);
                        }
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Lỗi hệ thống!");
                return;
            }
        }
        private void startNewGame(int level)
        {
            try
            {
                API.API api = new API.API();
                string rememberUser = "";
                string rememberAccessToken = "";
                if (this.getCookie(ref rememberUser, ref rememberAccessToken) == false)
                {
                    //not remember
                    MessageBox.Show("Bạn đã bị đăng xuất");
                    router.LoginFormControllerFlag = true;
                    view.Close();
                    return;
                }
                else
                {

                    string stringParams =
                        "rememberUserName=" + api.urlEndcode(rememberUser) +
                        "&rememberAccessToken=" + api.urlEndcode(rememberAccessToken) +
                        "&level=" + api.urlEndcode(""+level);
                    string resServerString = api.requestServer("/game/create", stringParams);
                    
                    dynamic resServer = JsonConvert.DeserializeObject(resServerString);

                    if (resServer.code == -1)
                    {
                        //error
                        if (resServer.error == "not_login")
                        {
                            MessageBox.Show("Bạn đã bị đăng xuất");
                            router.LoginFormControllerFlag = true;
                            view.Close();
                            return;
                        }
                        else if (resServer.error == "error")
                        {
                            MessageBox.Show("Lỗi hệ thống!");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Lỗi hệ thống!");
                            return;
                        }
                    }
                    else
                    {
                        //succes
                        this.level = resServer.data.level;
                        view.level = this.level;
                        view.widthImageItem = WIDTH_BIG_IMAGE / this.level;

                        string pathSaveImage = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                        pathSaveImage += @"\image\playing_images\" + resServer.data.imageName;
                        
                        if (!File.Exists(pathSaveImage)&&
                            api.downloadImage("/static/images/" + resServer.data.imageName, pathSaveImage) == false)
                        {
                            throw new Exception("error download image");
                        }
                        else
                        {
                            Image image = getImageFromPath(pathSaveImage);
                            this.playImage = image;
                            int[] matrix = resServer.data.matrix.ToObject<int[]>();
                            view.imageItems = getImageItems(image);
                            view.updateImageItemsIndex(matrix);

                            //set time
                            this.timeStart = resServer.data.timeStart;
                            this.timeMinus = 0;
                        }

                        view.setImageControls();
                        view.setSmallImage(level > 3 ? playImage : null);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi hệ thống!");
                return;
            }

        }


        private void winGame()
        {
            view.victoryFlag = true;
            view.pauseAble = false;
        }

        
        private ConstantResource.PlayFormImageItem[] getImageItems(Image bigImage)
        {
            ConstantResource.PlayFormImageItem[] items = new ConstantResource.PlayFormImageItem[level * level];
            Image[] images = splitImage(bigImage, level, WIDTH_BIG_IMAGE);
            for (int i = 0; i < level*level; i++)
            {
                items[i] = new ConstantResource.PlayFormImageItem
                {
                    id = i,
                    index = i,
                    image = images[i]
                };
            }
            return items;
        }

        public Image[] splitImage(Image bigImage, int level, int widthBigImage){
            var imgList = new Image[level*level];
            int widthSmallImage = widthBigImage / level;
            
            for (int i = 0; i < level*level-1; i++)
            {
                var imageItem = new Bitmap(widthSmallImage, widthSmallImage);
                var graphics = Graphics.FromImage(imageItem);
                graphics.DrawImage(
                    bigImage,
                    new Rectangle(0, 0, widthSmallImage, widthSmallImage),
                    new Rectangle((i % level) * widthSmallImage, (i / level) * widthSmallImage, widthSmallImage, widthSmallImage),
                    GraphicsUnit.Pixel);
                graphics.Dispose();
                imgList[i]=imageItem;
            }
            //empty image
            imgList[level*level-1] = new Bitmap(widthSmallImage, widthSmallImage);

            return imgList;
        }

        public Image getImageFromPath(string path)
        {
            Image img = Image.FromFile(path);
            return img;
        }


        public long getTimeNow()
        {
            DateTime dt = new DateTime(1970, 1, 1);//from 1970/1/1 00:00:00 to now

            DateTime dtNow = DateTime.UtcNow;

            TimeSpan result = dtNow - dt;

            long miniseconds = Convert.ToInt64(result.TotalSeconds*1000);

            return miniseconds;
        }
        public void timeLoop()
        {
            view.TimeSec = (int) (getTimeNow() - timeStart - timeMinus);
        }
        public void exit(bool fromView=false)
        {
            if (!IsPausing&&!view.victoryFlag)
            {
                pauseOrContinue();
            }

            if (!fromView)
            {
                router.MainFormControllerFlag = true;
                view.Close();
            }
            else
            {
            }
            threadTime.Abort();
        }

        public void pauseOrContinue()
        {
            if (IsPausing)
            {
                //continue
                continuePreviousGame();
                IsPausing = false;

            }
            else
            {
                if (view.victoryFlag) return;
                if (view.isLoading) return;

                try
                {
                    API.API api = new API.API();
                    string rememberUser = "";
                    string rememberAccessToken = "";
                    if (this.getCookie(ref rememberUser, ref rememberAccessToken) == false)
                    {
                        //not remember
                        MessageBox.Show("Bạn đã bị đăng xuất");
                        router.LoginFormControllerFlag = true;
                        view.Close();
                        return;
                    }
                    else
                    {

                        string stringParams =
                            "rememberUserName=" + api.urlEndcode(rememberUser) +
                            "&rememberAccessToken=" + api.urlEndcode(rememberAccessToken);
                        string resServerString = api.requestServer("/game/pause", stringParams);
                        dynamic resServer = JsonConvert.DeserializeObject(resServerString);

                        if (resServer.code == -1)
                        {
                            //error
                            if (resServer.error == "not_login")
                            {
                                MessageBox.Show("Bạn đã bị đăng xuất");
                                router.LoginFormControllerFlag = true;
                                view.Close();
                                return;
                            }
                            else if (resServer.error == "error")
                            {
                                MessageBox.Show("Lỗi hệ thống!");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Lỗi hệ thống!");
                                return;
                            }
                        }
                        else
                        {
                            //succes
                            IsPausing = true;
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Lỗi hệ thống!");
                    return;
                }
            }
        }


    }
}
