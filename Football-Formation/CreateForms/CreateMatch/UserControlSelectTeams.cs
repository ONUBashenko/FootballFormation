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
            foreach (var team in Team.GetAllTeams())
            {
                comboBoxHomeTeam.Items.Add(team);
                comboBoxAwayTeam.Items.Add(team);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxHomeTeam.SelectedItem == null || comboBoxAwayTeam.SelectedItem == null)
                {
                    throw new InvalidOperationException("Both teams must be selected.");
                }

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
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            parentForm.Close(); 
        }

        private void UpdateComboBoxes()
        {
            var selectedHome = comboBoxHomeTeam.SelectedItem as Team;
            var selectedAway = comboBoxAwayTeam.SelectedItem as Team;

            comboBoxHomeTeam.SelectedIndexChanged -= comboBoxHomeTeam_SelectedIndexChanged;
            comboBoxAwayTeam.SelectedIndexChanged -= comboBoxAwayTeam_SelectedIndexChanged;

            comboBoxHomeTeam.Items.Clear();
            comboBoxAwayTeam.Items.Clear();

            foreach (var team in Team.GetAllTeams())
            {
                if (team != selectedAway)
                    comboBoxHomeTeam.Items.Add(team);
                if (team != selectedHome)
                    comboBoxAwayTeam.Items.Add(team);
            }

            if (selectedHome != null && comboBoxHomeTeam.Items.Contains(selectedHome))
                comboBoxHomeTeam.SelectedItem = selectedHome;
            if (selectedAway != null && comboBoxAwayTeam.Items.Contains(selectedAway))
                comboBoxAwayTeam.SelectedItem = selectedAway;

            comboBoxHomeTeam.SelectedIndexChanged += comboBoxHomeTeam_SelectedIndexChanged;
            comboBoxAwayTeam.SelectedIndexChanged += comboBoxAwayTeam_SelectedIndexChanged;
        }

        private void comboBoxHomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxes();
        }

        private void comboBoxAwayTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxes();
        }
    }
}
