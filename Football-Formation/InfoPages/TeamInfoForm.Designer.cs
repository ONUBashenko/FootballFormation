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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeam).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTeam
            // 
            pictureBoxTeam.Location = new Point(1, -4);
            pictureBoxTeam.Name = "pictureBoxTeam";
            pictureBoxTeam.Size = new Size(182, 158);
            pictureBoxTeam.TabIndex = 16;
            pictureBoxTeam.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(260, 204);
            label4.Name = "label4";
            label4.Size = new Size(88, 32);
            label4.TabIndex = 15;
            label4.Text = "Players";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(260, 146);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 14;
            label3.Text = "Coach";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(260, 90);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 13;
            label2.Text = "Country";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(218, 21);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // TeamInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxTeam);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TeamInfoForm";
            Text = "TeamInfoForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxTeam;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}