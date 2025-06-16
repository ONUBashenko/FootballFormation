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
using static FootballFormation.Classes.FormationHelper;
using static FootballFormation.Classes.PositionInFormation;
using static FootballFormation.CreateForms.CreateMatch.CreateMatchForm;

namespace FootballFormation.CreateForms.CreateMatch
{
    public partial class UserControlAwayFormation : UserControl
    {
        private MatchData matchData;
        private List<ComboBox> comboBoxes;
        private List<Panel> panels;
        private Dictionary<PositionInFormation, Panel> availiblePanels;
        private bool isUpdatingComboBoxes = false;

        public UserControlAwayFormation(MatchData data)
        {
            InitializeComponent();
            this.matchData = data;
            AwayFormation.Text = $"{matchData.AwayTeam.Name} formation";
        }

        private void UserControlAwayFormation_Load(object sender, EventArgs e)
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

            foreach (var formation in matchData.AwayTeam.TeamCoach.Formations)
            {
                comboBoxAwayFormation.Items.Add(GetFormationString((FormationType)formation));
            }

            comboBoxes = new List<ComboBox>
            {
                comboBoxGoalkeeper,
                comboBoxLeftBack,
                comboBoxRightBack,
                comboBoxCenterBackLeft,
                comboBoxCenterBackCentral,
                comboBoxCenterBackRight,
                comboBoxLeftMidfielder,
                comboBoxRightMidfielder,
                comboBoxCenterMidfielderLeft,
                comboBoxCenterMidfielderCentral,
                comboBoxCenterMidfielderRight,
                comboBoxLeftWinger,
                comboBoxRightWinger,
                comboBoxStrikerLeft,
                comboBoxStrikerRight,
                comboBoxStrikerCentral
            };
            foreach (var comboBox in comboBoxes)
            {
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }

            PopulateComboBoxes();

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
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var parent = this.Parent;

            if (parent != null)
            {
                parent.Controls.Clear();
                var uc3 = new UserControlHomeFormation(matchData);
                parent.Controls.Add(uc3);
                uc3.Dock = DockStyle.Fill;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAwayFormation.SelectedItem == null)
                {
                    throw new InvalidOperationException("Formation type must be selected.");
                }
                TryParseFormation(comboBoxAwayFormation.SelectedItem.ToString(), out var formationName);

                var playersOnPositions = new Dictionary<PositionInFormation, Player>();

                foreach (var kvp in availiblePanels)
                {
                    var position = kvp.Key;
                    var panel = kvp.Value;

                    if (panel.Visible)
                    {
                        var comboBox = panel.Controls
                            .OfType<ComboBox>()
                            .FirstOrDefault();

                        if (comboBox != null && comboBox.SelectedItem is Player player)
                        {
                            playersOnPositions[position] = player;
                        }
                    }
                }

                matchData.AwayFormation = new Formation(formationName, playersOnPositions);

                matchData.Match = new Match(matchData.HomeTeam,
                matchData.AwayTeam,
                matchData.HomeFormation,
                matchData.AwayFormation);

                var parent = this.Parent;

                if (parent != null)
                {
                    parent.Controls.Clear();
                    var uc2 = new UserControlMatchSummary(matchData);
                    parent.Controls.Add(uc2);
                    uc2.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        private void comboBoxAwayFormation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAwayFormation.SelectedItem is string formationStr &&
                TryParseFormation(formationStr, out var formationType))
            {
                foreach (var panel in panels)
                {
                    panel.Visible = false;
                }

                var positions = FormationExtensions.SetPositionsInFormation(formationType);

                foreach (var position in positions)
                {
                    if (availiblePanels.TryGetValue(position.Key, out var panel))
                    {
                        panel.Visible = true;
                    }
                }

                foreach (var panel in availiblePanels.Values)
                {
                    foreach (var comboBox in panel.Controls.OfType<ComboBox>())
                    {
                        comboBox.SelectedItem = null;
                    }
                }
            }
        }

        private void PopulateComboBoxes()
        {
            foreach (var comboBox in comboBoxes)
            {
                comboBox.Items.Clear();
                foreach (var player in matchData.AwayTeam.Players)
                {
                    comboBox.Items.Add(player);
                }
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdatingComboBoxes) return;

            isUpdatingComboBoxes = true;

            try
            {
                var selectedPlayers = comboBoxes
                    .Where(cb => cb.SelectedItem != null)
                    .Select(cb => cb.SelectedItem)
                    .ToList();

                foreach (var comboBox in comboBoxes)
                {
                    var currentSelection = comboBox.SelectedItem;

                    comboBox.Items.Clear();

                    foreach (var player in matchData.AwayTeam.Players)
                    {
                        if (!selectedPlayers.Contains(player) || Equals(player, currentSelection))
                        {
                            comboBox.Items.Add(player);
                        }
                    }

                    if (currentSelection != null && comboBox.Items.Contains(currentSelection))
                    {
                        comboBox.SelectedItem = currentSelection;
                    }
                }
            }
            finally
            {
                isUpdatingComboBoxes = false;
            }
        }
    }
}
