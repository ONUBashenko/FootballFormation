namespace FootballFormation
{
    partial class PlayersPage
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
            CreatePlayer = new Button();
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
            label1.Size = new Size(137, 42);
            label1.TabIndex = 1;
            label1.Text = "Players";
            label1.Click += label1_Click;
            // 
            // CreatePlayer
            // 
            CreatePlayer.BackColor = SystemColors.Control;
            CreatePlayer.Location = new Point(949, 74);
            CreatePlayer.Name = "CreatePlayer";
            CreatePlayer.Size = new Size(118, 30);
            CreatePlayer.TabIndex = 4;
            CreatePlayer.Text = "Create player";
            CreatePlayer.UseVisualStyleBackColor = false;
            CreatePlayer.Click += CreatePlayer_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlDark;
            flowLayoutPanel1.Location = new Point(0, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1070, 465);
            flowLayoutPanel1.TabIndex = 13;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(0, 67);
            label2.Name = "label2";
            label2.Size = new Size(1070, 4);
            label2.TabIndex = 14;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // PlayersPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(CreatePlayer);
            Controls.Add(label1);
            Name = "PlayersPage";
            Size = new Size(1070, 587);
            Load += PlayersPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CreatePlayer;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
    }
}
