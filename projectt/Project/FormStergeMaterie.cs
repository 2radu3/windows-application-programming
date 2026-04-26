using Project.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project
{
    public partial class FormStergeMaterie : Form
    {
        public Disciplina MaterieSelectata { get; private set; }

        public FormStergeMaterie(List<Disciplina> discipline)
        {
            InitializeComponent();

            // Configurăm ComboBox-ul din acest formular (ex: cmbMateriiSterge)
            cmbStergeMaterie.DataSource = discipline;
            cmbStergeMaterie.DisplayMember = "Denumire";
            cmbStergeMaterie.SelectedIndex = -1;
        }

        private void btnStergeMaterie_Click(object sender, EventArgs e)
        {
            if (cmbStergeMaterie.SelectedItem == null)
            {
                MessageBox.Show("Vă rugăm selectați o materie de șters!");
                return;
            }

            MaterieSelectata = (Disciplina)cmbStergeMaterie.SelectedItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}