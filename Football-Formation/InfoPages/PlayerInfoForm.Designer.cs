namespace FootballFormation.InfoPages
{
    partial class PlayerInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerInfoForm));
            labelPlayerName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBoxPlayer = new PictureBox();
            label6 = new Label();
            labelPlayerAge = new Label();
            labelPlayerHeight = new Label();
            labelPlayerPosition = new Label();
            labelPlayerTeam = new Label();
            labelPlayerPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            SuspendLayout();
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 14F);
            labelPlayerName.Location = new Point(217, 25);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(78, 32);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(301, 94);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(271, 150);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 2;
            label3.Text = "Height";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(259, 208);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 3;
            label4.Text = "Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(286, 313);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 4;
            label5.Text = "Team";
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.BackgroundImage = (Image)resources.GetObject("pictureBoxPlayer.BackgroundImage");
            pictureBoxPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxPlayer.Location = new Point(0, 0);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(202, 188);
            pictureBoxPlayer.TabIndex = 5;
            pictureBoxPlayer.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(292, 260);
            label6.Name = "label6";
            label6.Size = new Size(65, 32);
            label6.TabIndex = 6;
            label6.Text = "Price";
            // 
            // labelPlayerAge
            // 
            labelPlayerAge.AutoSize = true;
            labelPlayerAge.Font = new Font("Segoe UI", 14F);
            labelPlayerAge.Location = new Point(377, 94);
            labelPlayerAge.Name = "labelPlayerAge";
            labelPlayerAge.Size = new Size(27, 32);
            labelPlayerAge.TabIndex = 7;
            labelPlayerAge.Text = "0";
            // 
            // labelPlayerHeight
            // 
            labelPlayerHeight.AutoSize = true;
            labelPlayerHeight.Font = new Font("Segoe UI", 14F);
            labelPlayerHeight.Location = new Point(377, 150);
            labelPlayerHeight.Name = "labelPlayerHeight";
            labelPlayerHeight.Size = new Size(27, 32);
            labelPlayerHeight.TabIndex = 8;
            labelPlayerHeight.Text = "0";
            // 
            // labelPlayerPosition
            // 
            labelPlayerPosition.AutoSize = true;
            labelPlayerPosition.Font = new Font("Segoe UI", 14F);
            labelPlayerPosition.Location = new Point(377, 208);
            labelPlayerPosition.Name = "labelPlayerPosition";
            labelPlayerPosition.Size = new Size(27, 32);
            labelPlayerPosition.TabIndex = 9;
            labelPlayerPosition.Text = "0";
            // 
            // labelPlayerTeam
            // 
            labelPlayerTeam.AutoSize = true;
            labelPlayerTeam.Font = new Font("Segoe UI", 14F);
            labelPlayerTeam.Location = new Point(377, 313);
            labelPlayerTeam.Name = "labelPlayerTeam";
            labelPlayerTeam.Size = new Size(27, 32);
            labelPlayerTeam.TabIndex = 11;
            labelPlayerTeam.Text = "0";
            // 
            // labelPlayerPrice
            // 
            labelPlayerPrice.AutoSize = true;
            labelPlayerPrice.Font = new Font("Segoe UI", 14F);
            labelPlayerPrice.Location = new Point(377, 260);
            labelPlayerPrice.Name = "labelPlayerPrice";
            labelPlayerPrice.Size = new Size(27, 32);
            labelPlayerPrice.TabIndex = 10;
            labelPlayerPrice.Text = "0";
            // 
            // PlayerInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPlayerTeam);
            Controls.Add(labelPlayerPrice);
            Controls.Add(labelPlayerPosition);
            Controls.Add(labelPlayerHeight);
            Controls.Add(labelPlayerAge);
            Controls.Add(label6);
            Controls.Add(pictureBoxPlayer);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelPlayerName);
            Name = "PlayerInfoForm";
            Text = "PlayerInfoForm";
            Load += PlayerInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlayerName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBoxPlayer;
        private Label label6;
        private Label labelPlayerAge;
        private Label labelPlayerHeight;
        private Label labelPlayerPosition;
        private Label labelPlayerTeam;
        private Label labelPlayerPrice;
    }
}