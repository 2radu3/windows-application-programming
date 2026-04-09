using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminar_04
{
    public partial class Form1 : Form
    {

        private List<Student> studenti = new List<Student>();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //Form1 form = (Form1)sender -> form.Text;
            MessageBox.Show($"Se deschide {this.Text}..."); //se afiseaza proprietatea de Text din proprierties
        }

        private void btnAdauga_Click(object sender, EventArgs e) {
            try {
                if(tbNume.Text == "") {
                    throw new Exception("\nNumele este invalid!");
                }

                if(string.IsNullOrEmpty(tbFacultate.Text)) {
                    throw new StudentValidareException("Facultatea nu e bine introdusa");
                }

                string nume = tbNume.Text;
                string facultate = tbFacultate.Text;
                string[] noteString = tbNote.Text.Split(',');
                int[] noteInt = new int[noteString.Length];
                for (int i = 0; i < noteString.Length; i++) {
                    noteInt[i] = int.Parse(noteString[i]);
                }
                Student s = new Student(nume, facultate, noteInt);
                s.CalculeazaMedie();
                MessageBox.Show(s.ToString());
                studenti.Add(s);
            }
            catch (StudentValidareException sve) { //prima pentru ca este derivata din exception
                MessageBox.Show(sve.Message, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            finally {
                tbNume.Clear();
                tbFacultate.Clear();
                tbNote.Clear();
            }
        }

        private void btnAfiseazaStud_Click(object sender, EventArgs e) {
            foreach(Student s in studenti) {
                tbStud.Text += s.ToString() + Environment.NewLine;
            }
        }

        private void btnAfiseazaStudLV_Click(object sender, EventArgs e) {
            listView1.Items.Clear();
            foreach(Student s in studenti) {
                ListViewItem lvi = new ListViewItem(s.Nume);
                lvi.SubItems.Add(s.Facultate);
                lvi.SubItems.Add(s.Medie.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog1.Filter = "(*.txt)|*.txt"; //ce am in stanga barii va aparea in save file dialog in save as
                                                      //ce e in dreapta e extensia fisierului
            if(saveFileDialog1.ShowDialog() == DialogResult.OK) {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach(Student s in studenti) {
                    sw.WriteLine(s.ToString());
                }
                sw.Close();
                MessageBox.Show($"S-a salvat fisierul {saveFileDialog1.FileName}");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) { //citirea din fisier
            openFileDialog1.Filter = "(*.txt)|*.txt";

            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                tbStud.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e) {
            FileStream fs = new FileStream("studenti.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, studenti);
            fs.Close();
            MessageBox.Show("S-a salvat fisierul studenti.dat");
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e) {
            FileStream fs = new FileStream("studenti.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Student> listaStudenti = (List<Student>) bf.Deserialize(fs);
            foreach(Student s in listaStudenti) {
                tbStud.Text += s.ToString() + "\n";
            }
            fs.Close(); 
            MessageBox.Show("S-a salvat fisierul studenti.dat");
        }
    }
}