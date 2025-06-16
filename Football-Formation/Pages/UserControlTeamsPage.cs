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
using FootballFormation.InfoPages;

namespace FootballFormation
{
    public partial class UserControlTeamsPage : UserControl
    {
        public UserControlTeamsPage()
        {
            InitializeComponent();

            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            CreateTeam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void TeamsPage_Load_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;

            RenderTeams();
        }

        private void CreateTeam_Click(object sender, EventArgs e)
        {
            CreateTeamForm createForm = new CreateTeamForm();
            var result = createForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                RenderTeams();
            }
        }

        private void RenderTeams()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var team in Team.GetAllTeams())
            {
                Panel panel = new Panel();
                panel.Width = 1000;
                panel.Height = 30;

                Label linkLabel = new Label();
                linkLabel.Text = team.Name;
                linkLabel.Width = 250;
                linkLabel.Location = new Point(5, 5);
                linkLabel.Tag = team;
                linkLabel.Click += LinkLabel_LinkClicked;

                Button deleteButton = new Button();
                deleteButton.Text = "Delete";
                deleteButton.Width = 80;
                deleteButton.Height = 30;
                deleteButton.Location = new Point(400, 2);
                deleteButton.Tag = team;
                deleteButton.Click += DeleteButton_Click;

                panel.Controls.Add(linkLabel);
                panel.Controls.Add(deleteButton);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;
                if (button?.Tag is Team teamToRemove)
                {
                    teamToRemove.Delete();
                    RenderTeams();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        private void LinkLabel_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                Label label = sender as Label;
                if (label?.Tag is Team team)
                {
                    TeamInfoForm infoForm = new TeamInfoForm(team);
                    infoForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }
    }
}
