
namespace game_sliding_puzzle.View
{
    partial class ChangePasswordView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordView));
            this.signUpLabelComfirmPassword = new System.Windows.Forms.Label();
            this.textBoxComfirmNewPassword = new System.Windows.Forms.TextBox();
            this.signUpLabelPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNotification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpLabelComfirmPassword
            // 
            this.signUpLabelComfirmPassword.AutoSize = true;
            this.signUpLabelComfirmPassword.Location = new System.Drawing.Point(19, 81);
            this.signUpLabelComfirmPassword.Name = "signUpLabelComfirmPassword";
            this.signUpLabelComfirmPassword.Size = new System.Drawing.Size(85, 28);
            this.signUpLabelComfirmPassword.TabIndex = 14;
            this.signUpLabelComfirmPassword.Text = "Comfirm New\r\nPassword";
            this.signUpLabelComfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxComfirmNewPassword
            // 
            this.textBoxComfirmNewPassword.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxComfirmNewPassword.Font = new System.Drawing.Font("Showcard Gothic", 13F);
            this.textBoxComfirmNewPassword.Location = new System.Drawing.Point(110, 81);
            this.textBoxComfirmNewPassword.MaxLength = 300;
            this.textBoxComfirmNewPassword.Name = "textBoxComfirmNewPassword";
            this.textBoxComfirmNewPassword.PasswordChar = '*';
            this.textBoxComfirmNewPassword.Size = new System.Drawing.Size(121, 29);
            this.textBoxComfirmNewPassword.TabIndex = 13;
            // 
            // signUpLabelPassword
            // 
            this.signUpLabelPassword.AutoSize = true;
            this.signUpLabelPassword.Location = new System.Drawing.Point(8, 54);
            this.signUpLabelPassword.Name = "signUpLabelPassword";
            this.signUpLabelPassword.Size = new System.Drawing.Size(96, 14);
            this.signUpLabelPassword.TabIndex = 12;
            this.signUpLabelPassword.Text = "New Password";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxNewPassword.Font = new System.Drawing.Font("Showcard Gothic", 13F);
            this.textBoxNewPassword.Location = new System.Drawing.Point(110, 45);
            this.textBoxNewPassword.MaxLength = 300;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(121, 29);
            this.textBoxNewPassword.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Old Password";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxOldPassword.Font = new System.Drawing.Font("Showcard Gothic", 13F);
            this.textBoxOldPassword.Location = new System.Drawing.Point(110, 10);
            this.textBoxOldPassword.MaxLength = 300;
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(121, 29);
            this.textBoxOldPassword.TabIndex = 15;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.LightCyan;
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.buttonChange.Location = new System.Drawing.Point(23, 116);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(100, 37);
            this.buttonChange.TabIndex = 17;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Wheat;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.buttonCancel.Location = new System.Drawing.Point(131, 116);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 37);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelNotification
            // 
            this.labelNotification.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotification.Location = new System.Drawing.Point(11, 160);
            this.labelNotification.Name = "labelNotification";
            this.labelNotification.Size = new System.Drawing.Size(231, 42);
            this.labelNotification.TabIndex = 19;
            this.labelNotification.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChangePasswordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(254, 211);
            this.Controls.Add(this.labelNotification);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.signUpLabelComfirmPassword);
            this.Controls.Add(this.textBoxComfirmNewPassword);
            this.Controls.Add(this.signUpLabelPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePasswordView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signUpLabelComfirmPassword;
        private System.Windows.Forms.TextBox textBoxComfirmNewPassword;
        private System.Windows.Forms.Label signUpLabelPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelNotification;
    }
}