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
    public partial class ChangePasswordView : Form
    {
        private ChangePasswordFormController controller;

        public ChangePasswordView()
        {
            InitializeComponent();
            controller = new ChangePasswordFormController();
        }

        public string ShowMessage
        {
            set
            {
                this.labelNotification.Text = ConstantResource.ChangePasswordFormMessageString.getStringFromResponse(value);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            ShowMessage = "waiting";
            string response = controller.changePassword(textBoxOldPassword.Text, textBoxNewPassword.Text, textBoxComfirmNewPassword.Text);
            ShowMessage = response;
            if (response == "change_success")
            {
                this.Close();
            }
        }

        private void ChangePasswordView_Load(object sender, EventArgs e)
        {

        }
    }
}
