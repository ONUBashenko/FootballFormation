namespace FootballFormation
{
    partial class CoachesPage
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
            CreateCoach = new Button();
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
            label2.Size = new Size(164, 42);
            label2.TabIndex = 6;
            label2.Text = "Coaches";
            // 
            // CreateCoach
            // 
            CreateCoach.BackColor = SystemColors.Control;
            CreateCoach.Location = new Point(950, 74);
            CreateCoach.Name = "CreateCoach";
            CreateCoach.Size = new Size(118, 30);
            CreateCoach.TabIndex = 8;
            CreateCoach.Text = "Create coach";
            CreateCoach.UseVisualStyleBackColor = false;
            CreateCoach.Click += CreateCoach_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlDark;
            flowLayoutPanel1.Location = new Point(0, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1071, 454);
            flowLayoutPanel1.TabIndex = 14;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 67);
            label1.Name = "label1";
            label1.Size = new Size(1070, 4);
            label1.TabIndex = 15;
            label1.Text = "label1";
            // 
            // CoachesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(CreateCoach);
            Controls.Add(label2);
            Name = "CoachesPage";
            Size = new Size(1071, 576);
            Load += CoachesPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button CreateCoach;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
    }
}
