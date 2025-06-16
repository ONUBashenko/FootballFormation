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
using static FootballFormation.Classes.PositionType;

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
            Array Positions = Enum.GetValues(typeof(PositionType));
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
                if (comboBoxPosition.SelectedItem == null)
                {
                    throw new ArgumentException("Position cannot be empty.");
                }

                new Player(textBoxName.Text,
                (int)numericUpDownAge.Value,
                (int)numericUpDownHeight.Value,
                (PositionType)comboBoxPosition.SelectedItem,
                (int)numericUpDownPrice.Value);

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
