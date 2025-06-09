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
using static FootballFormation.Classes.Player.PositionType;

namespace FootballFormation
{
    public partial class CreatePlayerForm : Form
    {
        public CreatePlayerForm()
        {
            InitializeComponent();
        }

        private void CreatePlayerForm_Load(object sender, EventArgs e)
        {
            comboBoxPosition.Items.Clear();
            Array Positions = Enum.GetValues(typeof(Player.PositionType));
            foreach (var position in Positions)
            {
                comboBoxPosition.Items.Add(position);
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
                new Player(textBoxName.Text,
                (int)numericUpDownAge.Value,
                (int)numericUpDownHeight.Value,
                (Player.PositionType)comboBoxPosition.SelectedItem,
                (int)numericUpDownPrice.Value);

                this.Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
            //PlayersPage.RenderPlayers();
        }

        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDownAge_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
