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
using System.Globalization;

namespace seminar_06
{
    public partial class Form1 : Form {
        List<Student> listaStudenti = new List<Student>();
        public Form1() {
            InitializeComponent();
            incarcaDate();
            lvStudenti.ContextMenuStrip = contextMenuStrip1;
            tvStudenti.ContextMenuStrip = contextMenuStrip2;
        }

    

    private void incarcaDate() {
            StreamReader sr = new StreamReader("Studenti.txt");
            string linie;
            while((linie = sr.ReadLine()) != null) {
                try {
                    int matricol = Convert.ToInt32(linie.Split(',')[0]);
                    string nume = linie.Split(',')[1];
                    float medie = float.Parse(linie.Split(',')[2], CultureInfo.InvariantCulture.NumberFormat);
                    Student s = new Student(matricol, nume, medie);
                    listaStudenti.Add(s);
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            MessageBox.Show("Datele au fost incarcate!");
        }

        private void btnPreluareLV_Click(object sender, EventArgs e) {
            foreach (Student s in listaStudenti) {
                ListViewItem item = new ListViewItem(s.matricol.ToString());
                item.SubItems.Add(s.nume);
                item.SubItems.Add(s.medie.ToString());

                if (s.medie > 9) {
                    item.SubItems.Add("Excelent");
                }
                else {
                    item.SubItems.Add("Bun");
                }

                lvStudenti.Items.Add(item);
            }
        }

        private void btnStergeElemLV_Click(object sender, EventArgs e) {
            foreach (ListViewItem itm in lvStudenti.Items)
                if (itm.Checked)
                    itm.Remove();
        }

        private void stergeElementLVToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (ListViewItem itm in lvStudenti.Items)
                if (itm.Checked)
                    itm.Remove();
        }

        private void lvStudenti_ItemChecked(object sender, ItemCheckedEventArgs e) {
            if(e.Item.Checked) {
                e.Item.BackColor = Color.Red;
            }
        }

        private void btnPopulareTV_Click(object sender, EventArgs e) {
            TreeNode parinte = new TreeNode("Studenti");
            tvStudenti.Nodes.Add(parinte);

            foreach (Student s in listaStudenti) {
                TreeNode copil = new TreeNode(s.matricol + "-" + s.nume);
                parinte.Nodes.Add(copil);

                TreeNode nepot = new TreeNode();
                if (s.medie > 9) {
                    nepot.Text = "Excelent";
                }
                else {
                    nepot.Text = "Bun";
                }
                copil.Nodes.Add(nepot);
            }

            tvStudenti.ExpandAll();
        }

        private void tvStudenti_AfterSelect(object sender, TreeViewEventArgs e) {
            TreeNode nodSelectat = tvStudenti.SelectedNode;
            int matricol;
            try {
                matricol = Convert.ToInt32(nodSelectat.Text.Split('-')[0]);
            }
            catch {
                matricol = 0;
            }

            foreach (Student s in listaStudenti) {
                if (s.matricol == matricol) {
                    tbStudenti.Text += s.ToString() + Environment.NewLine;
                }
            }
        }

        private void stergeElementTVToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode nodSelectat = tvStudenti.SelectedNode;
            if (nodSelectat.NextNode != null) {
                nodSelectat = tvStudenti.SelectedNode.NextNode;
            }
            else {
                if (nodSelectat.PrevNode != null) {
                    nodSelectat = tvStudenti.SelectedNode.PrevNode;
                }
            }

            tvStudenti.SelectedNode.Remove();
            tvStudenti.SelectedNode = nodSelectat;
        }
    }
}
