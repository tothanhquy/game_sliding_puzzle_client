using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game_sliding_puzzle.Controller;

namespace game_sliding_puzzle.View
{
    public partial class PlayFormView : Form
    {
        private PlayFormController controller;

        public bool victoryFlag
        {
            set
            {
                this.labelVictory.Visible = value;
            }
            get
            {
                return this.labelVictory.Visible;
            }
        }
        public bool isLoading
        {
            set
            {
                this.labelLoading.Visible = value;
            }
            get
            {
                return this.labelLoading.Visible;
            }
        }
        public bool isPausing
        {
            set
            {
                this.buttonPause.Text = value?"Continue":"Pause";
            }
        }
        public bool pauseAble
        {
            set
            {
                this.buttonPause.Enabled = value;
            }
        }
        public int level=3;
        public int widthImageItem = 1;

        public ConstantResource.PlayFormImageItem[] imageItems = null;
        private Panel[] imageControls; 

        public int TimeSec
        {
            set
            {
                this.labelTime.Text = ConstantResource.MainFormChartItem.convertTimeSec(value);
            }
        }

        public PlayFormView(PlayFormController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        public void setImageControls()
        {
            if (imageItems == null) return;

            imageControls = new Panel[this.level * this.level];
            for (int i = 0; i < level*level-1; i++)
            {
                imageControls[i] = new Panel
                {
                    BackgroundImage = imageItems[i].image,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom,
                    Location = new System.Drawing.Point((imageItems[i].index % level) * widthImageItem, (imageItems[i].index / level) * widthImageItem),
                    Margin = new System.Windows.Forms.Padding(0),
                    Name = "imageItem" + i,
                    Size = new System.Drawing.Size(widthImageItem, widthImageItem),
                    TabIndex = i,
                };
                this.panelContainerImage.Controls.Add(imageControls[i]);
            }
        }
        public void setSmallImage(Image img)
        {
            this.panelSmallImage.BackgroundImage = img;
        }
        public void changeImageItemPosition()
        {
            if (imageItems == null) return;

            for (int i = 0; i < level * level-1; i++)
            {
                imageControls[i].Location = new System.Drawing.Point((imageItems[i].index % level) * widthImageItem, (imageItems[i].index / level) * widthImageItem);
            }
        }

        public void updateImageItemsIndex(int[] indexs)
        {
            for (int i = 0; i < imageItems.Length; i++)
            {
                imageItems[i].index = indexs[i];
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            controller.exit();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys e)
        {
            controller.move(e);
            return true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            controller.timeLoop();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            controller.pauseOrContinue();
        }

        private void PlayFormView_Load(object sender, EventArgs e)
        {
            controller.formLoad();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            controller.exit(true);
            base.OnFormClosing(e);
        }
    }
}
