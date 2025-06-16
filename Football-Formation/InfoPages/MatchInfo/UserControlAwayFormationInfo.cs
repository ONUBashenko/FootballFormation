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
using static FootballFormation.Classes.PositionInFormation;
using static FootballFormation.Classes.FormationHelper;

namespace FootballFormation.InfoPages.MatchInfo
{
    public partial class UserControlAwayFormationInfo : UserControl
    {
        private Match match;
        private List<Panel> panels;
        private Dictionary<PositionInFormation, Panel> availiblePanels;
        private Dictionary<PositionInFormation, TextBox> positionTextBoxes;

        public UserControlAwayFormationInfo(Match match)
        {
            InitializeComponent();

            this.match = match;
        }

        private void UserControlAwayFormationInfo_Load(object sender, EventArgs e)
        {
            panels = new List<Panel>
            {
                panelStrikerLeft,
                panelStrikerRight,
                panelRightWinger,
                panelLeftWinger,
                panelLeftMidfielder,
                panelStrikerCentral,
                panelRightMidfielder,
                panelRightBack,
                panelLeftBack,
                panelGoalkeeper,
                panelCenterBackLeft,
                panelCenterBackCentral,
                panelCenterBackRight,
                panelCenterMidfielderLeft,
                panelCenterMidfielderCentral,
                panelCenterMidfielderRight
            };

            availiblePanels = new Dictionary<PositionInFormation, Panel>
            {
                { Goalkeeper, panelGoalkeeper },
                { LeftBack, panelLeftBack },
                { RightBack, panelRightBack },
                { CenterBackLeft, panelCenterBackLeft },
                { CenterBackCentral, panelCenterBackCentral },
                { CenterBackRight, panelCenterBackRight },
                { LeftMidfielder, panelLeftMidfielder },
                { RightMidfielder, panelRightMidfielder },
                { CenterMidfielderLeft, panelCenterMidfielderLeft },
                { CenterMidfielderCentral, panelCenterMidfielderCentral },
                { CenterMidfielderRight, panelCenterMidfielderRight },
                { LeftWinger, panelLeftWinger },
                { RightWinger, panelRightWinger },
                { StrikerLeft, panelStrikerLeft },
                { StrikerRight, panelStrikerRight },
                { StrikerCentral, panelStrikerCentral }
            };

            ShowPanels();

            positionTextBoxes = new Dictionary<PositionInFormation, TextBox>
            {
                { Goalkeeper, textBoxGoalkeeper },
                { LeftBack, textBoxLeftBack },
                { RightBack, textBoxRightBack },
                { CenterBackLeft, textBoxCenterBackLeft },
                { CenterBackCentral, textBoxCenterBackCentral },
                { CenterBackRight, textBoxCenterBackRight },
                { LeftMidfielder, textBoxLeftMidfielder },
                { RightMidfielder, textBoxRightMidfielder },
                { CenterMidfielderLeft, textBoxCenterMidfielderLeft },
                { CenterMidfielderCentral, textBoxCenterMidfielderCentral },
                { CenterMidfielderRight, textBoxCenterMidfielderRight },
                { LeftWinger, textBoxLeftWinger },
                { RightWinger, textBoxRightWinger },
                { StrikerLeft, textBoxStrikerLeft },
                { StrikerRight, textBoxStrikerRight },
                { StrikerCentral, textBoxStrikerCentral }
            };

            LoadAwayFormationInfo();
        }

        private void ShowPanels()
        {
            foreach (var panel in panels)
            {
                panel.Visible = false;
            }


            foreach (var position in match.AwayFormation.PositionsInFormation)
            {
                if (availiblePanels.TryGetValue(position.Key, out var panel))
                {
                    panel.Visible = true;
                }
            }
        }

        public void LoadAwayFormationInfo()
        {
            labelAwayFormation.Text = $"{match.AwayTeam.Name} formation";
            labelAwayFormationType.Text = GetFormationString(match.AwayFormation.FormationName);

            foreach (var kvp in positionTextBoxes)
            {
                var position = kvp.Key;
                var textBox = kvp.Value;

                if (match.AwayFormation.PlayersOnPositions.TryGetValue(position, out var player))
                {
                    textBox.Text = player.Name;
                }
                else
                {
                    textBox.Text = string.Empty;
                }

                textBox.ReadOnly = true;
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            var parent = this.Parent;

            if (parent != null)
            {
                parent.Controls.Clear();
                var uc3 = new UserControlHomeFormationInfo(match);
                parent.Controls.Add(uc3);
                uc3.Dock = DockStyle.Fill;
            }
        }
    }
}
