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
    public partial class LoginFormView : Form
    {
        private LoginFormController controller;

        public string SignInTextBoxUserText { 
            get => this.signInTextBoxUser.Text;
            set => this.signInTextBoxUser.Text = value;
        }
        public string SignInTextBoxPasswordText { 
            get => this.signInTextBoxPassword.Text;
            set => this.signInTextBoxPassword.Text = value;
        }
        public string SignInButtonSubmitText { 
            set => this.signInButtonSubmit.Text = value; 
        }
        public string SignUpButtonSubmitText { 
            set => this.signUpButtonSubmit.Text = value;
        }
        public string SignUpTextBoxPasswordText { 
            get => this.signUpTextBoxPassword.Text;
            set => this.signUpTextBoxPassword.Text = value;
        }
        public string SignUpTextBoxUserText { 
            get => this.signUpTextBoxUser.Text;
            set => this.signUpTextBoxUser.Text = value;
        }
        public string SignInErrorNotificationText {
            set => this.signInErrorNotification.Text = ConstantResource.LoginFormResponseString.getStringFromResponse(value); 
        }
        public string SignUpErrorNotificationText {
            set => this.signUpErrorNotification.Text = ConstantResource.LoginFormResponseString.getStringFromResponse(value);
        }
        public string SignInErrorNotificationStatus
        {
            set => this.signInErrorNotification.ForeColor = ConstantResource.ForeColorStatus.getColorFromStatus(value);
        }
        public string SignUpErrorNotificationStatus
        {
            set => this.signUpErrorNotification.ForeColor = ConstantResource.ForeColorStatus.getColorFromStatus(value);
        }
        public string SignUpTextBoxComfirmPasswordText { 
            get => this.signUpTextBoxComfirmPassword.Text; 
            set => this.signUpTextBoxComfirmPassword.Text = value; 
        }

        public LoginFormView(LoginFormController controller) :base()
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void signInButtonSubmit_Click(object sender, EventArgs e)
        {
            controller.signIn();
        }

        private void signUpButtonSubmit_Click(object sender, EventArgs e)
        {
            controller.signUp();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            SignInErrorNotificationText = "";
            SignUpErrorNotificationText = "";
        }
    }
}
