using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game_sliding_puzzle.View;
using System.Windows.Forms;
using game_sliding_puzzle.API;
using Newtonsoft.Json;

namespace game_sliding_puzzle.Controller
{
    public class MainFormController:Controller
    {
        private MainFormView view;
        private Router router;

        public MainFormController(Router router):base()
        {
            this.router = router;

            view = new MainFormView(this);
            loadData();
        }

        private void loadData()
        {
            try
            {
                API.API api = new API.API();
                string rememberUser="";
                string rememberAccessToken="";
                if (this.getCookie(ref rememberUser, ref rememberAccessToken) == false)
                {
                    //not remember
                    router.LoginFormControllerFlag = true;
                    return;
                }
                else
                {

                    string stringParams = "rememberUserName=" + api.urlEndcode(rememberUser) + "&rememberAccessToken=" + api.urlEndcode(rememberAccessToken);
                    string resServerString = api.requestServer("/main/get_charts", stringParams);
                    
                    dynamic resServer = JsonConvert.DeserializeObject(resServerString);

                    if (resServer.code == -1)
                    {
                        //error
                        if (resServer.error == "not_login")
                        {
                            router.LoginFormControllerFlag = true;
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
                        //success
                        ConstantResource.MainFormChartItem[] chart3x3 = new ConstantResource.MainFormChartItem[3];
                        for(int i=0;i< resServer.data.level3x3.Count; i++)
                        {
                            chart3x3[i] = new ConstantResource.MainFormChartItem(""+resServer.data.level3x3[i].user, int.Parse(""+(resServer.data.level3x3[i].point/1000)));
                        }
                        view.Level3x3Charts = chart3x3;
                        ConstantResource.MainFormChartItem[] chart4x4 = new ConstantResource.MainFormChartItem[3];
                        for (int i = 0; i < resServer.data.level4x4.Count; i++)
                        {
                            chart4x4[i] = new ConstantResource.MainFormChartItem("" + resServer.data.level4x4[i].user, int.Parse("" + (resServer.data.level4x4[i].point/1000)));
                        }
                        view.Level4x4Charts = chart4x4;
                        ConstantResource.MainFormChartItem[] chart5x5 = new ConstantResource.MainFormChartItem[3];
                        for (int i = 0; i < resServer.data.level5x5.Count; i++)
                        {
                            chart5x5[i] = new ConstantResource.MainFormChartItem("" + resServer.data.level5x5[i].user, int.Parse("" + (resServer.data.level5x5[i].point/1000)));
                        }
                        view.Level5x5Charts = chart5x5;
                        ConstantResource.MainFormChartItem[] chart6x6 = new ConstantResource.MainFormChartItem[3];
                        for (int i = 0; i < resServer.data.level6x6.Count; i++)
                        {
                            chart6x6[i] = new ConstantResource.MainFormChartItem("" + resServer.data.level6x6[i].user, int.Parse("" + (resServer.data.level6x6[i].point/1000)));
                        }
                        view.Level6x6Charts = chart6x6;

                        view.ContinuePreviousGame = resServer.data.playPause;
                        loadDataUser();
                        view.ShowDialog();
                    }

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi hệ thống!"+err);
            }
        }

        private void loadDataUser()
        {
            string userName = "";
            string accessToken = "";
            getCookie(ref userName, ref accessToken);
            view.UserName = userName;
        }

        private void loadDataCharts()
        {
            
        }

        public void logout()
        {
            try
            {
                API.API api = new API.API();
                string rememberUser = "";
                string rememberAccessToken = "";
                if (this.getCookie(ref rememberUser, ref rememberAccessToken) == false)
                {
                    //not remember
                    router.LoginFormControllerFlag = true;
                    return;
                }
                else
                {

                    string stringParams = "rememberUserName=" + api.urlEndcode(rememberUser) + "&rememberAccessToken=" + api.urlEndcode(rememberAccessToken);
                    string resServerString = api.requestServer("/account/logout", stringParams);
                    dynamic resServer = JsonConvert.DeserializeObject(resServerString);

                    if (resServer.code == -1)
                    {
                        //error
                        if (resServer.error == "not_login")
                        {
                            router.LoginFormControllerFlag = true;
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
                        //open login form        
                        router.LoginFormControllerFlag = true;
                        view.Close();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi hệ thống!");
            }
        }

        public void runContinuePreviousGame()
        {
            DataForPlayForm data = new DataForPlayForm(3, true);
            router.dataForPlayForm = data;
            router.PlayFormControllerFlag = true;
            view.Close();
        }

        public void changePassword()
        {
            ChangePasswordView changePasswordView = new ChangePasswordView();
            changePasswordView.ShowDialog();
        }
        public void play(int level)
        {
            DataForPlayForm data = new DataForPlayForm(level,false);
            router.dataForPlayForm = data;
            router.PlayFormControllerFlag = true;
            view.Close();
        }
    }
    
}
