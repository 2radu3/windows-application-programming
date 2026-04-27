using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace model_test_2
{
    public partial class Form1 : Form
    {
        private List<Angajat> listaAngajatiGlobal = new List<Angajat>();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNume.Text;
                int ore = int.Parse(tbOreLucrate.Text);
                float salOrar = float.Parse(tbSalariuOrar.Text);

                Angajat a = new Angajat(nume, ore, salOrar);
                a.calculeazaTotalSalariu();
                listaAngajatiGlobal.Add(a);
                MessageBox.Show("Angajat adaugat");
            } catch (Exception ex)
            {
                MessageBox.Show("EROARE", ex.Message);
            }
            
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            listViewAngajati.Items.Clear();

            foreach(Angajat a in listaAngajatiGlobal)
            {
                ListViewItem item = new ListViewItem(a.Nume);
                item.SubItems.Add(a.OreLucrate.ToString());
                item.SubItems.Add(a.SalariuOrar.ToString());
                item.SubItems.Add(a.SalariuLunar.ToString());

                item.Tag = a;

                listViewAngajati.Items.Add(item);
                
            }
        }

        private void listViewAngajati_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAngajati.SelectedItems.Count > 0)
            {
                Angajat selectat = (Angajat)listViewAngajati.SelectedItems[0].Tag;

                if (selectat != null)
                {
                    MessageBox.Show(selectat.ToString(), "Detalii Angajat Selectat");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "(*.txt)|*.txt";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine("Nume: salut");
                float sumaTotala = 0;
                sw.WriteLine("Lista angajati: ");
                foreach (Angajat a in listaAngajatiGlobal)
                {
                    sw.WriteLine(a.ToString());
                    sumaTotala += a.SalariuLunar;
                }
                sw.WriteLine($"Suma totala: {sumaTotala} ");
                sw.Close();
            }
            
            MessageBox.Show("Fisierul a fost generat");
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt)|*.txt";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                tbFirme.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
