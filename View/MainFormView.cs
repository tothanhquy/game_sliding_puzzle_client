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
    public partial class MainFormView : Form
    {
        private MainFormController controller;

        public MainFormView(MainFormController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        public ConstantResource.MainFormChartItem[] Level3x3Charts
        {
            set {
                this.top1Lever3x3LabelUserName.Text = (value!=null && value[0]!=null) ? value[0].userName : "";
                this.top1Lever3x3LabelTime.Text = (value != null && value[0]!=null) ? ConstantResource.MainFormChartItem.convertTimeSec(value[0].timeSec) : "";
                this.top2Lever3x3LabelUserName.Text = (value != null && value[1]!=null) ? value[1].userName : "";
                this.top2Lever3x3LabelTime.Text = (value != null && value[1]!=null) ? ConstantResource.MainFormChartItem.convertTimeSec(value[1].timeSec) : "";
                this.top3Lever3x3LabelUserName.Text = (value != null && value[2]!=null) ? value[2].userName : "";
                this.top3Lever3x3LabelTime.Text = (value != null && value[2]!=null) ? ConstantResource.MainFormChartItem.convertTimeSec(value[2].timeSec) : "";
            }
        }
        public ConstantResource.MainFormChartItem[] Level4x4Charts
        {
            set {
                this.top1Lever4x4LabelUserName.Text = (value != null && value[0]!=null) ? value[0].userName : "";
                this.top1Lever4x4LabelTime.Text = (value != null && value[0]!=null) ? ConstantResource.MainFormChartItem.convertTimeSec(value[0].timeSec) : "";
                this.top2Lever4x4LabelUserName.Text = (value != null && value[1]!=null) ? value[1].userName : "";
                this.top2Lever4x4LabelTime.Text = (value != null && value[1]!=null) ? ConstantResource.MainFormChartItem.convertTimeSec(value[1].timeSec) : "";
                this.top3Lever4x4LabelUserName.Text = (value != null && value[2]!=null) ? value[1].userName : "";
                this.top3Lever4x4LabelTime.Text = (value != null && value[2]!=null) ? ConstantResource.MainFormChartItem.convertTimeSec(value[2].timeSec) : "";
            }
        }
        public ConstantResource.MainFormChartItem[] Level5x5Charts
        {
            set {
                this.top1Lever5x5LabelUserName.Text = (value != null && value[0]!=null) ? value[0].userName : "";
                this.top1Lever5x5LabelTime.Text = (value != null && value[0]!=null) ? ConstantResource.MainFormChartItem.convertTimeSec(value[0].timeSec) : "";
                this.top2Lever5x5LabelUserName.Text = (value != null && value[1]!=null) ? value[1].userName : "";
                this.top2Lever5x5LabelTime.Text = (value != null && value[1]!=null) ? ConstantResource.MainFormChartItem.convertTimeSec(value[1].timeSec) : "";
                this.top3Lever5x5LabelUserName.Text = (value != null && value[2]!=null) ? value[2].userName : "";
                this.top3Lever5x5LabelTime.Text = (value != null && value[2]!=null) ? ConstantResource.MainFormChartItem.convertTimeSec(value[2].timeSec) : "";
            }
        }
        public ConstantResource.MainFormChartItem[] Level6x6Charts
        {
            set {
                this.top1Lever6x6LabelUserName.Text = (value != null && value[0]!=null) ? value[0].userName : "";
                this.top1Lever6x6LabelTime.Text = (value != null && value[0]!=null) ? ConstantResource.MainFormChartItem.convertTimeSec(value[0].timeSec) : "";
                this.top2Lever6x6LabelUserName.Text = (value != null && value[1]!=null) ? value[1].userName : "";
                this.top2Lever6x6LabelTime.Text = (value != null && value[1]!=null) ? ConstantResource.MainFormChartItem.convertTimeSec(value[1].timeSec) : "";
                this.top3Lever6x6LabelUserName.Text = (value!= null && value[2]!=null) ? value[2].userName : "";
                this.top3Lever6x6LabelTime.Text = (value != null && value[2]!=null) ? ConstantResource.MainFormChartItem.convertTimeSec(value[2].timeSec) : "";
            }
        }
        public string UserName
        {
            set
            {
                this.userNameLabel.Text = value;
            }
        }
        public bool ContinuePreviousGame
        {
            set
            {
                this.buttonContinuePreviousGame.Visible = value;
            }
        }

        private void MainFormView_Load(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            controller.logout();
        }

        private void changePasswordLabel_Click(object sender, EventArgs e)
        {
            controller.changePassword();
        }

        private void flowLayoutPanelLevel3x3_Click(object sender, EventArgs e)
        {
            controller.play(3);
        }

        private void flowLayoutPanelLevel4x4_Click(object sender, EventArgs e)
        {
            controller.play(4);
        }

        private void flowLayoutPanelLevel5x5_Click(object sender, EventArgs e)
        {
            controller.play(5);
        }

        private void flowLayoutPanelLevel6x6_Click(object sender, EventArgs e)
        {
            controller.play(6);
        }

        private void buttonContinuePreviousGame_Click(object sender, EventArgs e)
        {
            controller.runContinuePreviousGame();
        }
    }
}
