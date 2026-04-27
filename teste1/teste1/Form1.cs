using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste1
{
    public partial class Form1 : Form
    {
        private List<Student> listaStudentiGlobal = new List<Student>();


        public Form1()
        {
            InitializeComponent();
            List<string> lista = new List<string>{ "h" };
            Student s = new Student("Ionescu", "Mihai", 18, "matricol?", 9.3, lista);

            string informatii = s.ToString();

            MessageBox.Show(informatii);

            s = s + "programare windows";
           
            MessageBox.Show(s[1]);
            MessageBox.Show(s[99]);
        }

        private void btnAdaugaStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNume.Text;
                string prenume = tbPrenume.Text;
                int varsta = int.Parse(tbVarsta.Text);
                string matricol = tbMatricol.Text;
                double medie = double.Parse(tbMedie.Text);

                char[] separatori = new char[] { ',', ' ' };
                List<string> materii = tbMaterii.Text.Split(separatori, StringSplitOptions.RemoveEmptyEntries).ToList();

                Student s = new Student(nume, prenume, varsta, matricol, medie, materii);
                listaStudentiGlobal.Add(s);
                MessageBox.Show("ADAUGAT CU SUCCES");
            }
            catch (Exception ex)
            {
                MessageBox.Show("EROARE!!" + ex.Message);
            }
            
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            treeViewStudenti.Nodes.Clear();

            foreach(Student s in listaStudentiGlobal)
            {
                TreeNode nodMatricol = new TreeNode($"Matricol: {s.Matricol}");
                nodMatricol.Nodes.Add($"Nume: {s.Nume}");
                nodMatricol.Nodes.Add($"Prenume: {s.Prenume}");
                nodMatricol.Nodes.Add($"Varsta: {s.Varsta}");
                nodMatricol.Nodes.Add($"Medie: {s.Medie}");
                TreeNode nodMaterii = new TreeNode("Materii");
                
                if(s.Materii != null)
                {
                    foreach(string materie in s.Materii)
                    {
                        nodMaterii.Nodes.Add(materie);
                    }
                }
                nodMatricol.Nodes.Add(nodMaterii);
                treeViewStudenti.Nodes.Add(nodMatricol);
            }
            treeViewStudenti.ExpandAll();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "(*.dat)|*.dat";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach(Student s in listaStudentiGlobal)
                {
                    sw.WriteLine(s.ToString());
                }
                sw.Close();
                MessageBox.Show("S a salvat");
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.dat)|*.dat";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                tbStudenti.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
