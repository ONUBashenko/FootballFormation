namespace FootballFormation
{
    partial class UserControlTeamsPage
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
            label1 = new Label();
            CreateTeam = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22F);
            label1.Location = new Point(8, 25);
            label1.Name = "label1";
            label1.Size = new Size(126, 42);
            label1.TabIndex = 2;
            label1.Text = "Teams";
            // 
            // CreateTeam
            // 
            CreateTeam.BackColor = SystemColors.Control;
            CreateTeam.Location = new Point(949, 74);
            CreateTeam.Name = "CreateTeam";
            CreateTeam.Size = new Size(118, 30);
            CreateTeam.TabIndex = 6;
            CreateTeam.Text = "Create team";
            CreateTeam.UseVisualStyleBackColor = false;
            CreateTeam.Click += CreateTeam_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlDarkDark;
            flowLayoutPanel1.Location = new Point(0, 116);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1070, 445);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(-1, 67);
            label2.Name = "label2";
            label2.Size = new Size(1073, 4);
            label2.TabIndex = 15;
            label2.Text = "label1";
            // 
            // UserControlTeamsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(CreateTeam);
            Controls.Add(label1);
            Name = "UserControlTeamsPage";
            Size = new Size(1070, 561);
            Load += TeamsPage_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CreateTeam;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
    }
}
