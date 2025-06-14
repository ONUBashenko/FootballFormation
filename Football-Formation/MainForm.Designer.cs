namespace FootballFormation
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            panel1 = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.HighlightText;
            listBox1.Font = new Font("Segoe UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Players", "Coaches", "Teams", "Matches" });
            listBox1.Location = new Point(0, -1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(142, 116);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Location = new Point(148, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 560);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(140, -1);
            label1.Name = "label1";
            label1.Size = new Size(10, 563);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1218, 557);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            KeyPreview = true;
            Name = "MainForm";
            Text = "Football Formation";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox1;
        private Panel panel1;
        private Label label1;
    }
}
