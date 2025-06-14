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
            label1 = new Label();
            label6 = new Label();
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
            label5.Location = new Point(257, 315);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 10;
            label5.Text = "Team";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(257, 208);
            label4.Name = "label4";
            label4.Size = new Size(133, 32);
            label4.TabIndex = 9;
            label4.Text = "Formations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(257, 150);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 8;
            label3.Text = "Height";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(257, 94);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 7;
            label2.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(215, 25);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(257, 261);
            label6.Name = "label6";
            label6.Size = new Size(129, 32);
            label6.TabIndex = 12;
            label6.Text = "Experience";
            // 
            // CoachInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(pictureBoxCoach);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CoachInfoForm";
            Text = "CoachInfoForm";
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
        private Label label1;
        private Label label6;
    }
}