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

namespace FootballFormation.CreateForms.CreateMatch
{
    public partial class UserControlMatchSummary : UserControl
    {
        private MatchData matchData;

        public UserControlMatchSummary(MatchData matchData)
        {
            InitializeComponent();
            this.matchData = matchData;

            LoadMatchSummary();
        }

        private void UserControlMatchSummary_Load(object sender, EventArgs e)
        {
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.DialogResult = DialogResult.OK;
                parentForm.Close();
            }
        }

        public void LoadMatchSummary()
        {
            HomeTeam.Text = matchData.HomeTeam.Name;
            AwayTeam.Text = matchData.AwayTeam.Name;
            HomeTeamGoals.Text = matchData.Match.MatchEvents["Goals"].Item1.ToString();
            AwayTeamGoals.Text = matchData.Match.MatchEvents["Goals"].Item2.ToString();
            HomeTeamPossession.Text = matchData.Match.MatchEvents["Possession"].Item1.ToString() + '%';
            AwayTeamPossession.Text = matchData.Match.MatchEvents["Possession"].Item2.ToString() + '%';
            HomeTeamShots.Text = matchData.Match.MatchEvents["Shots"].Item1.ToString();
            AwayTeamShots.Text = matchData.Match.MatchEvents["Shots"].Item2.ToString();
            HomeTeamShotsOnTarget.Text = matchData.Match.MatchEvents["Shots on target"].Item1.ToString();
            AwayTeamShotsOnTarget.Text = matchData.Match.MatchEvents["Shots on target"].Item2.ToString();
            HomeTeamCorners.Text = matchData.Match.MatchEvents["Corners"].Item1.ToString();
            AwayTeamCorners.Text = matchData.Match.MatchEvents["Corners"].Item2.ToString();
            HomeTeamFouls.Text = matchData.Match.MatchEvents["Fouls"].Item1.ToString();
            AwayTeamFouls.Text = matchData.Match.MatchEvents["Fouls"].Item2.ToString();
            HomeTeamYellowCards.Text = matchData.Match.MatchEvents["Yellow cards"].Item1.ToString();
            AwayTeamYellowCards.Text = matchData.Match.MatchEvents["Yellow cards"].Item2.ToString();
            HomeTeamRedCards.Text = matchData.Match.MatchEvents["Red cards"].Item1.ToString();
            AwayTeamRedCards.Text = matchData.Match.MatchEvents["Red cards"].Item2.ToString();
        }
    }
}
