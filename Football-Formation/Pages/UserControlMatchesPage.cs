using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballFormation.Classes;
using FootballFormation.CreateForms;
using FootballFormation.CreateForms.CreateMatch;

namespace FootballFormation
{
    public partial class UserControlMatchesPage : UserControl
    {
        public UserControlMatchesPage()
        {
            InitializeComponent();

            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            CreateMatch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void MatchesPage_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;

            RenderMatches();
        }

        private void CreateMatch_Click(object sender, EventArgs e)
        {
            CreateMatchForm createForm = new CreateMatchForm();
            createForm.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void RenderMatches()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var match in Match.GetAllMatches())
            {
                Panel panel = new Panel();
                panel.Width = 1000;
                panel.Height = 30;

                Label label = new Label();
                label.Text = match.HomeTeam.Name + " : " + match.AwayTeam.Name;
                label.Width = 150;
                label.Location = new Point(5, 5);

                Button deleteButton = new Button();
                deleteButton.Text = "Delete";
                deleteButton.Width = 80;
                deleteButton.Height = 30;
                deleteButton.Location = new Point(400, 2);
                deleteButton.Tag = match;
                deleteButton.Click += DeleteButton_Click;

                panel.Controls.Add(label);
                panel.Controls.Add(deleteButton);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;
                if (button?.Tag is Match matchToRemove)
                {
                    matchToRemove.Delete();
                    RenderMatches();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }
    }
}
