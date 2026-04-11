using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class Form1 : Form
    {
        private List<Sala> listaSali;
        private List<Disciplina> listaDiscipline;
        private List<string> listaIntervaleOrare;
        private List<Profesor> listaProfesori;

        private List<ElementOrar> listaOrarGlobal = new List<ElementOrar>();

        public Form1()
        {
            InitializeComponent();

            listaProfesori = new List<Profesor>();

            listaProfesori.Add(new Profesor { Id = 1, Nume = "Ionescu", Prenume = "Andrei", TitluAcademic = "Conf. Dr." });

            ActualizeazaTabel();
            ActualizeazaInterfata();
        }

        private void ActualizeazaTabel()
        {
            dgvProfesori.DataSource = null;
            dgvProfesori.DataSource = listaProfesori;
            cmbProfesor.DataSource = null;
            cmbProfesor.DataSource = listaProfesori;
            cmbProfesor.SelectedIndex = -1;
        }

        private void InitializareValoriDefault()
        {
            listaSali = new List<Sala>
            {
                new Sala {Denumire = "Amf. III", Capacitate = 100 },
                new Sala {Denumire = "2104", Capacitate = 100 },
                new Sala {Denumire = "2016", Capacitate = 20 },
                new Sala {Denumire = "B202", Capacitate = 30 },
                new Sala {Denumire = "2415", Capacitate = 20 },
                new Sala {Denumire = "2017", Capacitate = 25 },
                new Sala {Denumire = "2102", Capacitate = 100 },
                new Sala {Denumire = "2013B", Capacitate = 20 },
                new Sala {Denumire = "2103", Capacitate = 100 }
            };

            listaDiscipline = new List<Disciplina>
            {
                new Disciplina { Id = 1, Denumire = "Programarea Aplicatiilor Windows" },
                new Disciplina { Id = 2, Denumire = "SGBD Oracle" },
                new Disciplina { Id = 3, Denumire = "Programare multiparadigma - Java" },
                new Disciplina { Id = 3, Denumire = "Macroeconomie Cantitativa" },
                new Disciplina { Id = 3, Denumire = "Programare evolutiva si algoritmi genetici" },
                new Disciplina { Id = 3, Denumire = "Managementul riscului in afaceri internationale" },
                new Disciplina { Id = 3, Denumire = "Structuri de Date" }
            };

            listaIntervaleOrare = new List<string> { "07:30", "09:10", "10:50", "12:30", "14:10", "15:50", "17:30", "19:10" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(tbNume.Text) || string.IsNullOrWhiteSpace(tbPrenume.Text))
            {
                MessageBox.Show("Castele nu pot fi lasate goale!", "Eroare de completare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTitlu.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteaza un titlu academic!", "Eroare selecție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Profesor nou = new Profesor
            {
                Id = listaProfesori.Count + 1,
                Nume = tbNume.Text,
                Prenume = tbPrenume.Text,
                TitluAcademic = cmbTitlu.Text
            };

            listaProfesori.Add(nou);
            ActualizeazaTabel();

            tbNume.Clear();
            tbPrenume.Clear();
            cmbTitlu.SelectedIndex = -1;

            //SalveazaInFisierText();
            ActualizeazaInterfata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializareValoriDefault();
            //IncarcaDinFisierText();

            cmbProfesor.DataSource = null;
            cmbProfesor.DataSource = listaProfesori;
            cmbProfesor.SelectedIndex = -1;

            cmbSala.DataSource = listaSali;
            cmbSala.SelectedIndex = -1;

            cmbDisciplina.DataSource = listaDiscipline;
            cmbDisciplina.SelectedIndex = -1;

            cmbOra.DataSource = listaIntervaleOrare;
            cmbOra.SelectedIndex = -1;

            dgvProfesori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProfesori.ScrollBars = ScrollBars.Vertical;
            dgvProfesori.ReadOnly = true;
            dgvProfesori.AllowUserToAddRows = false;
            dgvProfesori.RowHeadersVisible = false;
            dgvProfesori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAdaugaInOrar_Click(object sender, EventArgs e)
        {
            Profesor profSelectat = (Profesor)cmbProfesor.SelectedItem;
            Sala salaSelectata = (Sala)cmbSala.SelectedItem;
            Disciplina discSelectata = (Disciplina)cmbDisciplina.SelectedItem;
            string oraSelectata = cmbOra.SelectedItem?.ToString();
            string ziuaNoua = cmbZiua.SelectedItem?.ToString();

            if (profSelectat == null || salaSelectata == null || discSelectata == null || string.IsNullOrEmpty(oraSelectata) || ziuaNoua == null)
            {
                MessageBox.Show("Selecteaza profesorul, sala, disciplina, ziua si ora!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var programare in listaOrarGlobal)
            {
                if (programare.Ziua == ziuaNoua && programare.IntervalOrar == oraSelectata)
                {
                    if (programare.SalaSarcina.Denumire == salaSelectata.Denumire)
                    {
                        MessageBox.Show($"Sala {salaSelectata.Denumire} este deja ocupata de {programare.ProfesorSarcina.Nume} la aceasta ora.", "Eroare suprapunere", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (programare.ProfesorSarcina.Id == profSelectat.Id)
                    {
                        MessageBox.Show($"{profSelectat.Nume} are deja un curs in sala {programare.SalaSarcina.Denumire} la aceasta ora.", "Eroare suprapunere", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            ElementOrar intrareNoua = new ElementOrar
            {
                Id = listaOrarGlobal.Count + 1,
                ProfesorSarcina = profSelectat,
                SalaSarcina = salaSelectata,
                DisciplinaSarcina = discSelectata,
                Ziua = cmbZiua.SelectedItem.ToString(),
                IntervalOrar = oraSelectata
            };

            listaOrarGlobal.Add(intrareNoua);

            MessageBox.Show($"Adaugat cu succes pentru {profSelectat.Nume}!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //SalveazaInFisierText();
        }

        private void btnAfiseazaOrar_Click(object sender, EventArgs e)
        {
            Profesor profCautat = (Profesor)cmbProfesor.SelectedItem;

            if (profCautat == null)
            {
                MessageBox.Show("Selecteaza un profesor!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ElementOrar> orarFiltrat = new List<ElementOrar>();
            foreach (var item in listaOrarGlobal)
            {
                if (item.ProfesorSarcina.Id == profCautat.Id)
                {
                    orarFiltrat.Add(item);
                }
            }

            FormAfisareOrar fereastraPopUp = new FormAfisareOrar(orarFiltrat, profCautat.ToString());
            fereastraPopUp.ShowDialog();
        }

        private void SalveazaInFisierText()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("profesori.txt"))
                {
                    foreach (var p in listaProfesori)
                    {
                        sw.WriteLine($"{p.Id}|{p.Nume}|{p.Prenume}|{p.TitluAcademic}");
                    }
                }

                using (StreamWriter sw = new StreamWriter("orar.txt"))
                {
                    foreach (var o in listaOrarGlobal)
                    {
                        sw.WriteLine($"{o.Id}|{o.ProfesorSarcina.Id}|{o.SalaSarcina.Id}|{o.DisciplinaSarcina.Id}|{o.Ziua}|{o.IntervalOrar}");
                    }
                }

                using (StreamWriter sw = new StreamWriter("sali.txt")) {
                    foreach (var s in listaSali) {
                        sw.WriteLine($"{s.Id}|{s.Denumire}|{s.Capacitate}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }

        private void IncarcaDinFisierText()
        {
            if (File.Exists("sali.txt")) {
                try {
                    listaSali.Clear();
                    string[] liniiSali = File.ReadAllLines("sali.txt");
                    foreach (var linie in liniiSali) {
                        var date = linie.Split('|');
                        listaSali.Add(new Sala {
                            Id = int.Parse(date[0]),
                            Denumire = date[1],
                            Capacitate = int.Parse(date[2])
                        });
                    }
                    cmbSala.DataSource = null;
                    cmbSala.DataSource = listaSali;
                    cmbSala.DisplayMember = "Denumire";
                    cmbSala.SelectedIndex = -1;
                }
                catch (Exception ex) { MessageBox.Show("Eroare încarcare sali: " + ex.Message); }
            }
            else {
                InitializareValoriDefault();
            }

            if (!File.Exists("profesori.txt")) return;
            try
            {
                listaProfesori.Clear();
                string[] liniiProf = File.ReadAllLines("profesori.txt");
                foreach (var linie in liniiProf)
                {
                    var date = linie.Split('|');
                    listaProfesori.Add(new Profesor
                    {
                        Id = int.Parse(date[0]),
                        Nume = date[1],
                        Prenume = date[2],
                        TitluAcademic = date[3]
                    });
                }

                if (File.Exists("orar.txt"))
                {
                    listaOrarGlobal.Clear();
                    string[] liniiOrar = File.ReadAllLines("orar.txt");
                    foreach (var linie in liniiOrar)
                    {
                        var d = linie.Split('|');

                        int idProf = int.Parse(d[1]);
                        int idSala = int.Parse(d[2]);
                        int idDisc = int.Parse(d[3]);

                        listaOrarGlobal.Add(new ElementOrar
                        {
                            Id = int.Parse(d[0]),
                            ProfesorSarcina = listaProfesori.FirstOrDefault(p => p.Id == idProf),
                            SalaSarcina = listaSali.FirstOrDefault(s => s.Id == idSala),
                            DisciplinaSarcina = listaDiscipline.FirstOrDefault(disc => disc.Id == idDisc),
                            Ziua = d[4],
                            IntervalOrar = d[5]
                        });
                    }
                }
                ActualizeazaTabel();
                ActualizeazaInterfata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare: " + ex.Message);
            }
        }

        private void btnStergeOrar_Click(object sender, EventArgs e)
        {
            Profesor profSelectat = (Profesor)cmbProfesor.SelectedItem;
            Sala salaSelectata = (Sala)cmbSala.SelectedItem;
            string ziuaSelectata = cmbZiua.SelectedItem?.ToString();
            string oraSelectata = cmbOra.SelectedItem?.ToString();

            if (profSelectat == null || salaSelectata == null || ziuaSelectata == null || oraSelectata == null)
            {
                MessageBox.Show("Selectati toate campurile pentru a identifica elementul de sters!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool gasit = false;
            for (int i = listaOrarGlobal.Count - 1; i >= 0; i--)
            {
                var item = listaOrarGlobal[i];

                if (item.ProfesorSarcina.Nume == profSelectat.Nume &&
                    item.SalaSarcina.Denumire == salaSelectata.Denumire &&
                    item.Ziua == ziuaSelectata &&
                    item.IntervalOrar == oraSelectata)
                {
                    listaOrarGlobal.RemoveAt(i);
                    gasit = true;
                    break;
                }
            }

            if (gasit)
            {
                //SalveazaInFisierText();
                MessageBox.Show("Programarea a fost stearsa cu succes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nu s-a gasit nicio programare care sa corespunda acestor selectii!");
            }
            //ActualizeazaInterfata();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalveazaInFisierText();
            MessageBox.Show("Datele au fost salvate cu succes!", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("profesori.txt") && File.Exists("orar.txt"))
            {
                IncarcaDinFisierText();
                //ActualizeazaComboBoxProfesori();
                cmbProfesor.DataSource = null;
                cmbProfesor.DataSource = listaProfesori;
                MessageBox.Show("Datele au fost incarcate", "Incarcare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nu s-au gasit fisierele de salvare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizeazaInterfata()
        {
            int nr = listaProfesori.Count;

            this.Text = $"Program Gestiune Orar - {nr} Profesori Inregistrati";

            lblStatistici.Text = $"In sistem sunt inregistrati {nr} profesori.";
        }

        private void tbCautare_TextChanged(object sender, EventArgs e)
        {
            string filtru = tbCautare.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filtru))
            {
                dgvProfesori.DataSource = null;
                dgvProfesori.DataSource = listaProfesori;
            }
            else
            {
                var rezultateFiltrate = listaProfesori
                    .Where(p => (p.Nume != null && p.Nume.ToLower().Contains(filtru)) ||
                                (p.Prenume != null && p.Prenume.ToLower().Contains(filtru)))
                    .ToList();

                dgvProfesori.DataSource = null;
                dgvProfesori.DataSource = rezultateFiltrate;
            }

            lblStatistici.Text = $"Rezultate găsite: {dgvProfesori.Rows.Count}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvProfesori.SelectedRows.Count > 0)
            {
                Profesor profDeSters = (Profesor)dgvProfesori.SelectedRows[0].DataBoundItem;

                var confirmare = MessageBox.Show($"Sigur vrei sa stergi profesorul {profDeSters.Nume}?",
                                 "Confirmare Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmare == DialogResult.Yes)
                {
                    listaProfesori.Remove(profDeSters);

                    listaOrarGlobal.RemoveAll(o => o.ProfesorSarcina.Id == profDeSters.Id);

                    ActualizeazaTabel();
                    cmbProfesor.DataSource = null;
                    cmbProfesor.DataSource = listaProfesori;
                    ActualizeazaInterfata();
                    //SalveazaInFisierText();

                    MessageBox.Show("Profesorul a fost sters.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecteaza un rand intreg din tabel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProfesori_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProfesori.SelectedRows.Count > 0)
            {
                Profesor profSelectatInTabel = (Profesor)dgvProfesori.SelectedRows[0].DataBoundItem;

                if (profSelectatInTabel != null)
                {
                    cmbProfesor.SelectedItem = profSelectatInTabel;
                }
            }
        }

        private void dgvProfesori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Profesor profSelectat = (Profesor)dgvProfesori.Rows[e.RowIndex].DataBoundItem;

                if (profSelectat != null)
                {
                    foreach (var item in cmbProfesor.Items)
                    {
                        if (((Profesor)item).Id == profSelectat.Id)
                        {
                            cmbProfesor.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
        }
        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e) {
            using (var formaSala = new FormAdaugaSala()) {
                if (formaSala.ShowDialog() == DialogResult.OK) {
                    bool existaDeja = listaSali.Any(s => s.Denumire.Trim().ToLower() == formaSala.SalaNoua.Denumire.Trim().ToLower());

                    if (existaDeja) {
                        MessageBox.Show($"Sala '{formaSala.SalaNoua.Denumire}' exista deja!",
                                        "Sala duplicata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    listaSali.Add(formaSala.SalaNoua);

                    cmbSala.DataSource = null;
                    cmbSala.DataSource = listaSali;
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e) {
            using (FormStergeSala f = new FormStergeSala(listaSali)) {
                if (f.ShowDialog() == DialogResult.OK) {
                    Sala deSters = f.SalaSelectata;              
                    listaSali.Remove(deSters);
                    listaOrarGlobal.RemoveAll(o => o.SalaSarcina.Denumire == deSters.Denumire);
                    cmbSala.DataSource = null;
                    cmbSala.DataSource = listaSali;
                    cmbSala.DisplayMember = "Denumire";
                    cmbSala.SelectedIndex = -1;

                    MessageBox.Show($"Sala {deSters.Denumire} a fost stearsa.");
                }
            }
        }
    }
}
