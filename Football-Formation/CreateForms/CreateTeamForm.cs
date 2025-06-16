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

namespace FootballFormation.CreateForms
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {
            comboBoxCoach.Items.Clear();
            foreach (var coach in Coach.GetAllCoaches())
            {
                if(coach.Team == null)
                    comboBoxCoach.Items.Add(coach);
            }

            checkedListBoxPlayers.Items.Clear();
            foreach (var player in Player.GetAllPlayers())
            {
                if(player.Team == null)
                    checkedListBoxPlayers.Items.Add(player, false);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedPlayers = new List<Player>();
                foreach (var item in checkedListBoxPlayers.CheckedItems)
                {
                    if (item is Player player)
                    {
                        selectedPlayers.Add(player);
                    }
                }

                new Team(textBoxName.Text,
                textBoxCountry.Text,
                (Coach)comboBoxCoach.SelectedItem,
                selectedPlayers);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }
    }
}
