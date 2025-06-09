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
            foreach (var coach in Coach.coaches)
            {
                //if(coach.Team != null) continue;
                comboBoxCoach.Items.Add(coach);
            }

            checkedListBoxPlayers.Items.Clear();
            foreach (var player in Player.players)
            {
                //if(player.Team != null) continue;
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

            var selectedPlayers = new List<Player>();
            foreach (var item in checkedListBoxPlayers.CheckedItems)
            {
                if (item is Player player)
                {
                    selectedPlayers.Add(player);
                }
            }
 
            try
            {
                new Team(textBoxName.Text,
                textBoxCountry.Text,
                (Coach)comboBoxCoach.SelectedItem,
                selectedPlayers);

                this.Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxCountry_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxCoach_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
