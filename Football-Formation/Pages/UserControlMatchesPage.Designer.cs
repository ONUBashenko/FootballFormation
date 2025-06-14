namespace FootballFormation
{
    partial class UserControlMatchesPage
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
            CreateMatch = new Button();
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
            label1.Size = new Size(157, 42);
            label1.TabIndex = 6;
            label1.Text = "Matches";
            // 
            // CreateMatch
            // 
            CreateMatch.BackColor = SystemColors.Control;
            CreateMatch.Location = new Point(949, 74);
            CreateMatch.Name = "CreateMatch";
            CreateMatch.Size = new Size(118, 30);
            CreateMatch.TabIndex = 8;
            CreateMatch.Text = "Create match";
            CreateMatch.UseVisualStyleBackColor = false;
            CreateMatch.Click += CreateMatch_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlDark;
            flowLayoutPanel1.Location = new Point(-1, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1070, 437);
            flowLayoutPanel1.TabIndex = 14;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(-1, 67);
            label2.Name = "label2";
            label2.Size = new Size(1073, 4);
            label2.TabIndex = 16;
            label2.Text = "label1";
            // 
            // UserControlMatchesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(CreateMatch);
            Controls.Add(label1);
            Name = "UserControlMatchesPage";
            Size = new Size(1070, 561);
            Load += MatchesPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button CreateMatch;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
    }
}
