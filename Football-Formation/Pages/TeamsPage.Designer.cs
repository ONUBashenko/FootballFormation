namespace FootballFormation
{
    partial class TeamsPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            CreateTeam = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 22F);
            label2.Location = new Point(8, 25);
            label2.Name = "label2";
            label2.Size = new Size(126, 42);
            label2.TabIndex = 2;
            label2.Text = "Teams";
            // 
            // CreateTeam
            // 
            CreateTeam.BackColor = SystemColors.Control;
            CreateTeam.Location = new Point(951, 74);
            CreateTeam.Name = "CreateTeam";
            CreateTeam.Size = new Size(118, 30);
            CreateTeam.TabIndex = 6;
            CreateTeam.Text = "Create team";
            CreateTeam.UseVisualStyleBackColor = false;
            CreateTeam.Click += CreateTeam_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlDark;
            flowLayoutPanel1.Location = new Point(-1, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1074, 452);
            flowLayoutPanel1.TabIndex = 14;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint_1;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(-1, 67);
            label1.Name = "label1";
            label1.Size = new Size(1073, 4);
            label1.TabIndex = 15;
            label1.Text = "label1";
            // 
            // TeamsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(CreateTeam);
            Controls.Add(label2);
            Name = "TeamsPage";
            Size = new Size(1072, 575);
            Load += TeamsPage_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button CreateTeam;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
    }
}
