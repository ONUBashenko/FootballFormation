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

namespace FootballFormation.CreateForms
{
    public partial class CreateCoachForm : Form
    {
        public CreateCoachForm()
        {
            InitializeComponent();
        }

        private void CreateCoachForm_Load(object sender, EventArgs e)
        {
            checkedListBoxFormations.Items.Clear();
            Array Formations = Enum.GetValues(typeof(FormationType));
            foreach (var formation in Formations)
            {
                checkedListBoxFormations.Items.Add(GetFormationString((FormationType)formation));
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var selectedFormations = new List<FormationType>();
            foreach (var item in checkedListBoxFormations.CheckedItems)
            {
                if (item is string formationString &&
                    TryParseFormation(formationString, out var formation))
                {
                    selectedFormations.Add(formation);
                }
            }

            try
            {
                new Coach(
                textBoxName.Text,
                (int)numericUpDownAge.Value,
                (int)numericUpDownHeight.Value,
                (int)numericUpDownExperience.Value,
                selectedFormations);

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

        private void numericUpDownAge_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDownExperience_ValueChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBoxFormations_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
