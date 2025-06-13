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
    public partial class UserControlHomeFormation : UserControl
    {
        private MatchData matchData;
        private List<ComboBox> comboBoxes;
        private List<Panel> panels;
        private Dictionary<PositionInFormation, Panel> availiblePanels;
        private bool isUpdatingComboBoxes = false;

        public UserControlHomeFormation(MatchData data)
        {
            InitializeComponent();
            this.matchData = data;
            HomeFormation.Text = $"{matchData.HomeTeam.Name} formation";
        }

        private void UserControlHomeFormation_Load(object sender, EventArgs e)
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

            foreach (var formation in matchData.HomeTeam.TeamCoach.Formations)
            {
                comboBoxHomeFormation.Items.Add(GetFormationString((FormationType)formation));
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
                var uc3 = new UserControlSelectTeams();
                parent.Controls.Add(uc3);
                uc3.Dock = DockStyle.Fill;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxHomeFormation.SelectedItem == null)
                {
                    throw new InvalidOperationException("Formation type must be selected.");
                }
                TryParseFormation(comboBoxHomeFormation.SelectedItem.ToString(), out var formationName);

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

                matchData.HomeFormation = new Formation(formationName, playersOnPositions);

                var parent = this.Parent;

                if (parent != null)
                {
                    parent.Controls.Clear();
                    var uc2 = new UserControlAwayFormation(matchData);
                    parent.Controls.Add(uc2);
                    uc2.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        private void comboBoxHomeFormation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxHomeFormation.SelectedItem is string formationStr &&
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
            }
        }

        private void PopulateComboBoxes()
        {
            foreach (var comboBox in comboBoxes)
            {
                comboBox.Items.Clear();
                foreach (var player in matchData.HomeTeam.Players)
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

                    foreach (var player in matchData.HomeTeam.Players)
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
