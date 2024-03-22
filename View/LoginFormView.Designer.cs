
namespace game_sliding_puzzle.View
{
    public partial class LoginFormView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFormView));
            this.topicLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.signInLabelPassword = new System.Windows.Forms.Label();
            this.signInLabelUserName = new System.Windows.Forms.Label();
            this.signInErrorNotification = new System.Windows.Forms.Label();
            this.signInButtonSubmit = new System.Windows.Forms.Button();
            this.signInTextBoxPassword = new System.Windows.Forms.TextBox();
            this.signInTextBoxUser = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.signUpLabelComfirmPassword = new System.Windows.Forms.Label();
            this.signUpTextBoxComfirmPassword = new System.Windows.Forms.TextBox();
            this.signUpLabelPassword = new System.Windows.Forms.Label();
            this.signUpLabelUserName = new System.Windows.Forms.Label();
            this.signUpErrorNotification = new System.Windows.Forms.Label();
            this.signUpButtonSubmit = new System.Windows.Forms.Button();
            this.signUpTextBoxPassword = new System.Windows.Forms.TextBox();
            this.signUpTextBoxUser = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.BackColor = System.Drawing.Color.Transparent;
            this.topicLabel.Font = new System.Drawing.Font("Showcard Gothic", 19F);
            this.topicLabel.ForeColor = System.Drawing.Color.Teal;
            this.topicLabel.Location = new System.Drawing.Point(251, 27);
            this.topicLabel.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(212, 33);
            this.topicLabel.TabIndex = 2;
            this.topicLabel.Text = "Sliding Puzzle";
            this.topicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.tabControl1.Location = new System.Drawing.Point(215, 84);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(271, 255);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.signInLabelPassword);
            this.tabPage1.Controls.Add(this.signInLabelUserName);
            this.tabPage1.Controls.Add(this.signInErrorNotification);
            this.tabPage1.Controls.Add(this.signInButtonSubmit);
            this.tabPage1.Controls.Add(this.signInTextBoxPassword);
            this.tabPage1.Controls.Add(this.signInTextBoxUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(263, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sign In";
            // 
            // signInLabelPassword
            // 
            this.signInLabelPassword.AutoSize = true;
            this.signInLabelPassword.Location = new System.Drawing.Point(34, 58);
            this.signInLabelPassword.Name = "signInLabelPassword";
            this.signInLabelPassword.Size = new System.Drawing.Size(75, 15);
            this.signInLabelPassword.TabIndex = 5;
            this.signInLabelPassword.Text = "Password";
            // 
            // signInLabelUserName
            // 
            this.signInLabelUserName.AutoSize = true;
            this.signInLabelUserName.Location = new System.Drawing.Point(35, 22);
            this.signInLabelUserName.Name = "signInLabelUserName";
            this.signInLabelUserName.Size = new System.Drawing.Size(74, 15);
            this.signInLabelUserName.TabIndex = 4;
            this.signInLabelUserName.Text = "User Name";
            // 
            // signInErrorNotification
            // 
            this.signInErrorNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.signInErrorNotification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signInErrorNotification.Font = new System.Drawing.Font("Arial", 13F);
            this.signInErrorNotification.ForeColor = System.Drawing.Color.Red;
            this.signInErrorNotification.Location = new System.Drawing.Point(25, 143);
            this.signInErrorNotification.Name = "signInErrorNotification";
            this.signInErrorNotification.Size = new System.Drawing.Size(219, 64);
            this.signInErrorNotification.TabIndex = 3;
            this.signInErrorNotification.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // signInButtonSubmit
            // 
            this.signInButtonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButtonSubmit.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.signInButtonSubmit.Location = new System.Drawing.Point(88, 85);
            this.signInButtonSubmit.Name = "signInButtonSubmit";
            this.signInButtonSubmit.Size = new System.Drawing.Size(93, 37);
            this.signInButtonSubmit.TabIndex = 2;
            this.signInButtonSubmit.Text = "Sign In";
            this.signInButtonSubmit.UseVisualStyleBackColor = true;
            this.signInButtonSubmit.Click += new System.EventHandler(this.signInButtonSubmit_Click);
            // 
            // signInTextBoxPassword
            // 
            this.signInTextBoxPassword.BackColor = System.Drawing.Color.AntiqueWhite;
            this.signInTextBoxPassword.Font = new System.Drawing.Font("Showcard Gothic", 13F);
            this.signInTextBoxPassword.Location = new System.Drawing.Point(110, 50);
            this.signInTextBoxPassword.MaxLength = 300;
            this.signInTextBoxPassword.Name = "signInTextBoxPassword";
            this.signInTextBoxPassword.PasswordChar = '*';
            this.signInTextBoxPassword.Size = new System.Drawing.Size(121, 29);
            this.signInTextBoxPassword.TabIndex = 1;
            // 
            // signInTextBoxUser
            // 
            this.signInTextBoxUser.BackColor = System.Drawing.Color.AntiqueWhite;
            this.signInTextBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signInTextBoxUser.Font = new System.Drawing.Font("Showcard Gothic", 13F);
            this.signInTextBoxUser.Location = new System.Drawing.Point(110, 15);
            this.signInTextBoxUser.MaxLength = 20;
            this.signInTextBoxUser.Name = "signInTextBoxUser";
            this.signInTextBoxUser.Size = new System.Drawing.Size(120, 29);
            this.signInTextBoxUser.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPage2.Controls.Add(this.signUpLabelComfirmPassword);
            this.tabPage2.Controls.Add(this.signUpTextBoxComfirmPassword);
            this.tabPage2.Controls.Add(this.signUpLabelPassword);
            this.tabPage2.Controls.Add(this.signUpLabelUserName);
            this.tabPage2.Controls.Add(this.signUpErrorNotification);
            this.tabPage2.Controls.Add(this.signUpButtonSubmit);
            this.tabPage2.Controls.Add(this.signUpTextBoxPassword);
            this.tabPage2.Controls.Add(this.signUpTextBoxUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(263, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sign Up";
            // 
            // signUpLabelComfirmPassword
            // 
            this.signUpLabelComfirmPassword.AutoSize = true;
            this.signUpLabelComfirmPassword.Location = new System.Drawing.Point(29, 88);
            this.signUpLabelComfirmPassword.Name = "signUpLabelComfirmPassword";
            this.signUpLabelComfirmPassword.Size = new System.Drawing.Size(75, 30);
            this.signUpLabelComfirmPassword.TabIndex = 10;
            this.signUpLabelComfirmPassword.Text = "Comfirm\r\nPassword";
            this.signUpLabelComfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // signUpTextBoxComfirmPassword
            // 
            this.signUpTextBoxComfirmPassword.BackColor = System.Drawing.Color.AntiqueWhite;
            this.signUpTextBoxComfirmPassword.Font = new System.Drawing.Font("Showcard Gothic", 13F);
            this.signUpTextBoxComfirmPassword.Location = new System.Drawing.Point(110, 88);
            this.signUpTextBoxComfirmPassword.MaxLength = 300;
            this.signUpTextBoxComfirmPassword.Name = "signUpTextBoxComfirmPassword";
            this.signUpTextBoxComfirmPassword.PasswordChar = '*';
            this.signUpTextBoxComfirmPassword.Size = new System.Drawing.Size(121, 29);
            this.signUpTextBoxComfirmPassword.TabIndex = 9;
            // 
            // signUpLabelPassword
            // 
            this.signUpLabelPassword.AutoSize = true;
            this.signUpLabelPassword.Location = new System.Drawing.Point(35, 60);
            this.signUpLabelPassword.Name = "signUpLabelPassword";
            this.signUpLabelPassword.Size = new System.Drawing.Size(75, 15);
            this.signUpLabelPassword.TabIndex = 8;
            this.signUpLabelPassword.Text = "Password";
            // 
            // signUpLabelUserName
            // 
            this.signUpLabelUserName.AutoSize = true;
            this.signUpLabelUserName.Location = new System.Drawing.Point(35, 24);
            this.signUpLabelUserName.Name = "signUpLabelUserName";
            this.signUpLabelUserName.Size = new System.Drawing.Size(74, 15);
            this.signUpLabelUserName.TabIndex = 7;
            this.signUpLabelUserName.Text = "User Name";
            // 
            // signUpErrorNotification
            // 
            this.signUpErrorNotification.Font = new System.Drawing.Font("Arial", 13F);
            this.signUpErrorNotification.ForeColor = System.Drawing.Color.Red;
            this.signUpErrorNotification.Location = new System.Drawing.Point(35, 174);
            this.signUpErrorNotification.Name = "signUpErrorNotification";
            this.signUpErrorNotification.Size = new System.Drawing.Size(192, 39);
            this.signUpErrorNotification.TabIndex = 6;
            this.signUpErrorNotification.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // signUpButtonSubmit
            // 
            this.signUpButtonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButtonSubmit.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.signUpButtonSubmit.Location = new System.Drawing.Point(77, 123);
            this.signUpButtonSubmit.Name = "signUpButtonSubmit";
            this.signUpButtonSubmit.Size = new System.Drawing.Size(100, 37);
            this.signUpButtonSubmit.TabIndex = 5;
            this.signUpButtonSubmit.Text = "Sign Up";
            this.signUpButtonSubmit.UseVisualStyleBackColor = true;
            this.signUpButtonSubmit.Click += new System.EventHandler(this.signUpButtonSubmit_Click);
            // 
            // signUpTextBoxPassword
            // 
            this.signUpTextBoxPassword.BackColor = System.Drawing.Color.AntiqueWhite;
            this.signUpTextBoxPassword.Font = new System.Drawing.Font("Showcard Gothic", 13F);
            this.signUpTextBoxPassword.Location = new System.Drawing.Point(110, 52);
            this.signUpTextBoxPassword.MaxLength = 300;
            this.signUpTextBoxPassword.Name = "signUpTextBoxPassword";
            this.signUpTextBoxPassword.PasswordChar = '*';
            this.signUpTextBoxPassword.Size = new System.Drawing.Size(121, 29);
            this.signUpTextBoxPassword.TabIndex = 4;
            // 
            // signUpTextBoxUser
            // 
            this.signUpTextBoxUser.BackColor = System.Drawing.Color.AntiqueWhite;
            this.signUpTextBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signUpTextBoxUser.Font = new System.Drawing.Font("Showcard Gothic", 13F);
            this.signUpTextBoxUser.Location = new System.Drawing.Point(110, 17);
            this.signUpTextBoxUser.MaxLength = 20;
            this.signUpTextBoxUser.Name = "signUpTextBoxUser";
            this.signUpTextBoxUser.Size = new System.Drawing.Size(120, 29);
            this.signUpTextBoxUser.TabIndex = 3;
            // 
            // LoginFormView
            // 
            this.AccessibleName = "";
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.topicLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginFormView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sliding Puzzle Game by Me.e";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox signInTextBoxUser;
        private System.Windows.Forms.TextBox signInTextBoxPassword;
        private System.Windows.Forms.Button signInButtonSubmit;
        private System.Windows.Forms.Button signUpButtonSubmit;
        private System.Windows.Forms.TextBox signUpTextBoxPassword;
        private System.Windows.Forms.TextBox signUpTextBoxUser;
        private System.Windows.Forms.Label signInErrorNotification;
        private System.Windows.Forms.Label signUpErrorNotification;
        #endregion

        private System.Windows.Forms.Label signInLabelUserName;
        private System.Windows.Forms.Label signInLabelPassword;
        private System.Windows.Forms.Label signUpLabelPassword;
        private System.Windows.Forms.Label signUpLabelUserName;
        private System.Windows.Forms.Label signUpLabelComfirmPassword;
        private System.Windows.Forms.TextBox signUpTextBoxComfirmPassword;
    }
}