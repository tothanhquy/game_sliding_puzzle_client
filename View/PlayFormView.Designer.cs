
namespace game_sliding_puzzle.View
{
    partial class PlayFormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayFormView));
            this.panelContainerImage = new System.Windows.Forms.Panel();
            this.topicLabel = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelSmallImage = new System.Windows.Forms.Panel();
            this.labelVictory = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.labelLoading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelContainerImage
            // 
            this.panelContainerImage.BackColor = System.Drawing.Color.Transparent;
            this.panelContainerImage.Location = new System.Drawing.Point(5, 5);
            this.panelContainerImage.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainerImage.Name = "panelContainerImage";
            this.panelContainerImage.Size = new System.Drawing.Size(450, 450);
            this.panelContainerImage.TabIndex = 0;
            this.panelContainerImage.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.BackColor = System.Drawing.Color.Transparent;
            this.topicLabel.Font = new System.Drawing.Font("Showcard Gothic", 29F);
            this.topicLabel.ForeColor = System.Drawing.Color.Teal;
            this.topicLabel.Location = new System.Drawing.Point(488, 9);
            this.topicLabel.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(170, 98);
            this.topicLabel.TabIndex = 3;
            this.topicLabel.Text = "Sliding\r\nPuzzle";
            this.topicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.buttonExit.Location = new System.Drawing.Point(527, 402);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(93, 37);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTime.Location = new System.Drawing.Point(497, 123);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(148, 41);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "00:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSmallImage
            // 
            this.panelSmallImage.BackColor = System.Drawing.Color.Transparent;
            this.panelSmallImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelSmallImage.Location = new System.Drawing.Point(497, 178);
            this.panelSmallImage.Margin = new System.Windows.Forms.Padding(0);
            this.panelSmallImage.Name = "panelSmallImage";
            this.panelSmallImage.Size = new System.Drawing.Size(150, 150);
            this.panelSmallImage.TabIndex = 6;
            // 
            // labelVictory
            // 
            this.labelVictory.AutoSize = true;
            this.labelVictory.BackColor = System.Drawing.Color.Teal;
            this.labelVictory.Font = new System.Drawing.Font("Showcard Gothic", 80F);
            this.labelVictory.ForeColor = System.Drawing.Color.LightYellow;
            this.labelVictory.Location = new System.Drawing.Point(80, 170);
            this.labelVictory.Margin = new System.Windows.Forms.Padding(0);
            this.labelVictory.Name = "labelVictory";
            this.labelVictory.Size = new System.Drawing.Size(522, 133);
            this.labelVictory.TabIndex = 7;
            this.labelVictory.Text = "Victory";
            this.labelVictory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVictory.Visible = false;
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPause.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.buttonPause.Location = new System.Drawing.Point(503, 331);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(142, 37);
            this.buttonPause.TabIndex = 9;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Showcard Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(60, 331);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.labelLoading.Size = new System.Drawing.Size(585, 123);
            this.labelLoading.TabIndex = 10;
            this.labelLoading.Text = "Game Loading ...";
            // 
            // PlayFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.labelVictory);
            this.Controls.Add(this.panelSmallImage);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.topicLabel);
            this.Controls.Add(this.panelContainerImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PlayFormView";
            this.Text = "Sliding Puzzle Game by Me.e";
            this.Load += new System.EventHandler(this.PlayFormView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContainerImage;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelSmallImage;
        private System.Windows.Forms.Label labelVictory;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Label labelLoading;
    }
}