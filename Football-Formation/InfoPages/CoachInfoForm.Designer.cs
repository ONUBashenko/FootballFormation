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
            labelCoachExperiance = new Label();
            labelCoachHeight = new Label();
            labelCoachAge = new Label();
            listBoxFormations = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoach).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCoach
            // 
            pictureBoxCoach.Location = new Point(-2, 0);
            pictureBoxCoach.Name = "pictureBoxCoach";
            pictureBoxCoach.Size = new Size(182, 158);
            pictureBoxCoach.TabIndex = 11;
            pictureBoxCoach.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(286, 262);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 10;
            label5.Text = "Team";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(502, 98);
            label4.Name = "label4";
            label4.Size = new Size(133, 32);
            label4.TabIndex = 9;
            label4.Text = "Formations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(271, 154);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 8;
            label3.Text = "Height";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(301, 98);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 7;
            label2.Text = "Age";
            // 
            // labelCoachName
            // 
            labelCoachName.AutoSize = true;
            labelCoachName.Font = new Font("Segoe UI", 14F);
            labelCoachName.Location = new Point(215, 25);
            labelCoachName.Name = "labelCoachName";
            labelCoachName.Size = new Size(78, 32);
            labelCoachName.TabIndex = 6;
            labelCoachName.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(228, 204);
            label6.Name = "label6";
            label6.Size = new Size(129, 32);
            label6.TabIndex = 12;
            label6.Text = "Experience";
            // 
            // labelCoachTeam
            // 
            labelCoachTeam.AutoSize = true;
            labelCoachTeam.Font = new Font("Segoe UI", 14F);
            labelCoachTeam.Location = new Point(374, 262);
            labelCoachTeam.Name = "labelCoachTeam";
            labelCoachTeam.Size = new Size(27, 32);
            labelCoachTeam.TabIndex = 17;
            labelCoachTeam.Text = "0";
            // 
            // labelCoachExperiance
            // 
            labelCoachExperiance.AutoSize = true;
            labelCoachExperiance.Font = new Font("Segoe UI", 14F);
            labelCoachExperiance.Location = new Point(374, 209);
            labelCoachExperiance.Name = "labelCoachExperiance";
            labelCoachExperiance.Size = new Size(27, 32);
            labelCoachExperiance.TabIndex = 16;
            labelCoachExperiance.Text = "0";
            // 
            // labelCoachHeight
            // 
            labelCoachHeight.AutoSize = true;
            labelCoachHeight.Font = new Font("Segoe UI", 14F);
            labelCoachHeight.Location = new Point(374, 154);
            labelCoachHeight.Name = "labelCoachHeight";
            labelCoachHeight.Size = new Size(27, 32);
            labelCoachHeight.TabIndex = 14;
            labelCoachHeight.Text = "0";
            // 
            // labelCoachAge
            // 
            labelCoachAge.AutoSize = true;
            labelCoachAge.Font = new Font("Segoe UI", 14F);
            labelCoachAge.Location = new Point(374, 98);
            labelCoachAge.Name = "labelCoachAge";
            labelCoachAge.Size = new Size(27, 32);
            labelCoachAge.TabIndex = 13;
            labelCoachAge.Text = "0";
            // 
            // listBoxFormations
            // 
            listBoxFormations.BackColor = SystemColors.Window;
            listBoxFormations.FormattingEnabled = true;
            listBoxFormations.Location = new Point(659, 83);
            listBoxFormations.Name = "listBoxFormations";
            listBoxFormations.SelectionMode = SelectionMode.None;
            listBoxFormations.Size = new Size(93, 104);
            listBoxFormations.TabIndex = 18;
            // 
            // CoachInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxFormations);
            Controls.Add(labelCoachTeam);
            Controls.Add(labelCoachExperiance);
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
        private Label labelCoachExperiance;
        private Label labelCoachHeight;
        private Label labelCoachAge;
        private ListBox listBoxFormations;
    }
}