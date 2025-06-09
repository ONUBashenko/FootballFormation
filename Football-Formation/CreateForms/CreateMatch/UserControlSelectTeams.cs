using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FootballFormation.CreateForms.CreateMatch.CreateMatchForm;
using FootballFormation.Classes;

namespace FootballFormation.CreateForms.CreateMatch
{
    public partial class UserControlSelectTeams : UserControl
    {
        public UserControlSelectTeams()
        {
            InitializeComponent();
        }

        private void UserControlSelectTeams_Load(object sender, EventArgs e)
        {
            foreach (var team in Team.teams)
            {
                comboBoxHomeTeam.Items.Add(team);
                comboBoxAwayTeam.Items.Add(team);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Team homeTeam = (Team)comboBoxHomeTeam.SelectedItem;
            Team awayTeam = (Team)comboBoxAwayTeam.SelectedItem;

            MatchData matchData = new MatchData
            {
                HomeTeam = homeTeam,
                AwayTeam = awayTeam
            };

            var parent = this.Parent;

            if (parent != null)
            {
                parent.Controls.Clear();
                var uc2 = new UserControlHomeFormation(matchData);
                parent.Controls.Add(uc2);
                uc2.Dock = DockStyle.Fill;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            parentForm.Close(); 
        }

        private void comboBoxHomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxAwayTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
