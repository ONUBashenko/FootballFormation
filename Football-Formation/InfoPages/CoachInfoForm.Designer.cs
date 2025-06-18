namespace FootballFormation.InfoPages
{
    partial class CoachInfoForm
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
            pictureBoxCoach = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelCoachName = new Label();
            label6 = new Label();
            labelCoachTeam = new Label();
            labelCoachExperience = new Label();
            labelCoachHeight = new Label();
            labelCoachAge = new Label();
            listBoxFormations = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoach).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCoach
            // 
            pictureBoxCoach.BackColor = SystemColors.ButtonFace;
            pictureBoxCoach.BackgroundImage = Properties.Resources.CoachIcon;
            pictureBoxCoach.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxCoach.Location = new Point(-2, 0);
            pictureBoxCoach.Name = "pictureBoxCoach";
            pictureBoxCoach.Size = new Size(194, 186);
            pictureBoxCoach.TabIndex = 11;
            pictureBoxCoach.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(256, 232);
            label5.Name = "label5";
            label5.Size = new Size(76, 32);
            label5.TabIndex = 10;
            label5.Text = "Team:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(199, 287);
            label4.Name = "label4";
            label4.Size = new Size(138, 32);
            label4.TabIndex = 9;
            label4.Text = "Formations:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(241, 124);
            label3.Name = "label3";
            label3.Size = new Size(91, 32);
            label3.TabIndex = 8;
            label3.Text = "Height:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(271, 68);
            label2.Name = "label2";
            label2.Size = new Size(61, 32);
            label2.TabIndex = 7;
            label2.Text = "Age:";
            // 
            // labelCoachName
            // 
            labelCoachName.AutoSize = true;
            labelCoachName.Font = new Font("Segoe UI", 16F);
            labelCoachName.Location = new Point(198, 9);
            labelCoachName.Name = "labelCoachName";
            labelCoachName.Size = new Size(88, 37);
            labelCoachName.TabIndex = 6;
            labelCoachName.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(198, 174);
            label6.Name = "label6";
            label6.Size = new Size(134, 32);
            label6.TabIndex = 12;
            label6.Text = "Experience:";
            // 
            // labelCoachTeam
            // 
            labelCoachTeam.AutoSize = true;
            labelCoachTeam.Font = new Font("Segoe UI", 14F);
            labelCoachTeam.Location = new Point(337, 232);
            labelCoachTeam.Name = "labelCoachTeam";
            labelCoachTeam.Size = new Size(27, 32);
            labelCoachTeam.TabIndex = 17;
            labelCoachTeam.Text = "0";
            // 
            // labelCoachExperience
            // 
            labelCoachExperience.AutoSize = true;
            labelCoachExperience.Font = new Font("Segoe UI", 14F);
            labelCoachExperience.Location = new Point(337, 179);
            labelCoachExperience.Name = "labelCoachExperience";
            labelCoachExperience.Size = new Size(27, 32);
            labelCoachExperience.TabIndex = 16;
            labelCoachExperience.Text = "0";
            // 
            // labelCoachHeight
            // 
            labelCoachHeight.AutoSize = true;
            labelCoachHeight.Font = new Font("Segoe UI", 14F);
            labelCoachHeight.Location = new Point(337, 124);
            labelCoachHeight.Name = "labelCoachHeight";
            labelCoachHeight.Size = new Size(27, 32);
            labelCoachHeight.TabIndex = 14;
            labelCoachHeight.Text = "0";
            // 
            // labelCoachAge
            // 
            labelCoachAge.AutoSize = true;
            labelCoachAge.Font = new Font("Segoe UI", 14F);
            labelCoachAge.Location = new Point(337, 68);
            labelCoachAge.Name = "labelCoachAge";
            labelCoachAge.Size = new Size(27, 32);
            labelCoachAge.TabIndex = 13;
            labelCoachAge.Text = "0";
            // 
            // listBoxFormations
            // 
            listBoxFormations.BackColor = SystemColors.Window;
            listBoxFormations.FormattingEnabled = true;
            listBoxFormations.Location = new Point(341, 296);
            listBoxFormations.Name = "listBoxFormations";
            listBoxFormations.SelectionMode = SelectionMode.None;
            listBoxFormations.Size = new Size(93, 104);
            listBoxFormations.TabIndex = 18;
            // 
            // CoachInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxFormations);
            Controls.Add(labelCoachTeam);
            Controls.Add(labelCoachExperience);
            Controls.Add(labelCoachHeight);
            Controls.Add(labelCoachAge);
            Controls.Add(label6);
            Controls.Add(pictureBoxCoach);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelCoachName);
            Name = "CoachInfoForm";
            Text = "CoachInfoForm";
            Load += CoachInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCoach;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label labelCoachName;
        private Label label6;
        private Label labelCoachTeam;
        private Label labelCoachExperience;
        private Label labelCoachHeight;
        private Label labelCoachAge;
        private ListBox listBoxFormations;
    }
}