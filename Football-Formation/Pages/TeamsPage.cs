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

namespace FootballFormation
{
    public partial class TeamsPage : UserControl
    {
        public TeamsPage()
        {
            InitializeComponent();
        }

        private void TeamsPage_Load_1(object sender, EventArgs e)
        {
            RenderTeams();
        }

        private void CreateTeam_Click(object sender, EventArgs e)
        {
            CreateTeamForm createForm = new CreateTeamForm();
            createForm.ShowDialog();
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;
        }
        private void RenderTeams()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var team in Team.teams)
            {
                Panel panel = new Panel();
                panel.Width = 1000;
                panel.Height = 30;

                Label label = new Label();
                label.Text = team.Name;
                label.Width = 150;
                label.Location = new Point(5, 5);

                Button deleteButton = new Button();
                deleteButton.Text = "Delete";
                deleteButton.Width = 80;
                deleteButton.Height = 30;
                deleteButton.Location = new Point(400, 2);
                deleteButton.Tag = team;
                deleteButton.Click += DeleteButton_Click;

                panel.Controls.Add(label);
                panel.Controls.Add(deleteButton);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button?.Tag is Team teamToRemove)
            {
                Team.teams.Remove(teamToRemove);
                RenderTeams();
            }
        }
    }
}
