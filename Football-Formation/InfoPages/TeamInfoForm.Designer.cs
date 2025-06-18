namespace FootballFormation.InfoPages
{
    partial class TeamInfoForm
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
            pictureBoxTeam = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelTeamName = new Label();
            labelTeamCoach = new Label();
            labelTeamCountry = new Label();
            listBoxPlayers = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeam).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTeam
            // 
            pictureBoxTeam.BackgroundImage = Properties.Resources.TeamIcon;
            pictureBoxTeam.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxTeam.Location = new Point(1, -4);
            pictureBoxTeam.Name = "pictureBoxTeam";
            pictureBoxTeam.Size = new Size(197, 197);
            pictureBoxTeam.TabIndex = 16;
            pictureBoxTeam.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(232, 182);
            label4.Name = "label4";
            label4.Size = new Size(93, 32);
            label4.TabIndex = 15;
            label4.Text = "Players:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(240, 127);
            label3.Name = "label3";
            label3.Size = new Size(85, 32);
            label3.TabIndex = 14;
            label3.Text = "Coach:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(221, 76);
            label2.Name = "label2";
            label2.Size = new Size(104, 32);
            label2.TabIndex = 13;
            label2.Text = "Country:";
            // 
            // labelTeamName
            // 
            labelTeamName.AutoSize = true;
            labelTeamName.Font = new Font("Segoe UI", 16F);
            labelTeamName.Location = new Point(204, 9);
            labelTeamName.Name = "labelTeamName";
            labelTeamName.Size = new Size(88, 37);
            labelTeamName.TabIndex = 12;
            labelTeamName.Text = "Name";
            // 
            // labelTeamCoach
            // 
            labelTeamCoach.AutoSize = true;
            labelTeamCoach.Font = new Font("Segoe UI", 14F);
            labelTeamCoach.Location = new Point(331, 127);
            labelTeamCoach.Name = "labelTeamCoach";
            labelTeamCoach.Size = new Size(27, 32);
            labelTeamCoach.TabIndex = 18;
            labelTeamCoach.Text = "0";
            // 
            // labelTeamCountry
            // 
            labelTeamCountry.AutoSize = true;
            labelTeamCountry.Font = new Font("Segoe UI", 14F);
            labelTeamCountry.Location = new Point(331, 76);
            labelTeamCountry.Name = "labelTeamCountry";
            labelTeamCountry.Size = new Size(27, 32);
            labelTeamCountry.TabIndex = 17;
            labelTeamCountry.Text = "0";
            // 
            // listBoxPlayers
            // 
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.Location = new Point(271, 217);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.Size = new Size(413, 224);
            listBoxPlayers.TabIndex = 19;
            listBoxPlayers.SelectedIndexChanged += listBoxPlayers_SelectedIndexChanged;
            // 
            // TeamInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxPlayers);
            Controls.Add(labelTeamCoach);
            Controls.Add(labelTeamCountry);
            Controls.Add(pictureBoxTeam);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelTeamName);
            Name = "TeamInfoForm";
            Text = "TeamInfoForm";
            Load += TeamInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxTeam;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label labelTeamName;
        private Label labelTeamCoach;
        private Label labelTeamCountry;
        private ListBox listBoxPlayers;
    }
}