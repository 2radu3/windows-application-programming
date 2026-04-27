namespace model_test_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbOreLucrate = new System.Windows.Forms.TextBox();
            this.tbSalariuOrar = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.listViewAngajati = new System.Windows.Forms.ListView();
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOreLucrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSalariuOrar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSalariuTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbFirme = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(23, 37);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 20);
            this.tbNume.TabIndex = 0;
            // 
            // tbOreLucrate
            // 
            this.tbOreLucrate.Location = new System.Drawing.Point(23, 64);
            this.tbOreLucrate.Name = "tbOreLucrate";
            this.tbOreLucrate.Size = new System.Drawing.Size(100, 20);
            this.tbOreLucrate.TabIndex = 1;
            // 
            // tbSalariuOrar
            // 
            this.tbSalariuOrar.Location = new System.Drawing.Point(23, 91);
            this.tbSalariuOrar.Name = "tbSalariuOrar";
            this.tbSalariuOrar.Size = new System.Drawing.Size(100, 20);
            this.tbSalariuOrar.TabIndex = 2;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(23, 118);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // listViewAngajati
            // 
            this.listViewAngajati.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNume,
            this.chOreLucrate,
            this.chSalariuOrar,
            this.chSalariuTotal});
            this.listViewAngajati.FullRowSelect = true;
            this.listViewAngajati.HideSelection = false;
            this.listViewAngajati.Location = new System.Drawing.Point(489, 37);
            this.listViewAngajati.Name = "listViewAngajati";
            this.listViewAngajati.Size = new System.Drawing.Size(247, 202);
            this.listViewAngajati.TabIndex = 4;
            this.listViewAngajati.UseCompatibleStateImageBehavior = false;
            this.listViewAngajati.View = System.Windows.Forms.View.Details;
            this.listViewAngajati.SelectedIndexChanged += new System.EventHandler(this.listViewAngajati_SelectedIndexChanged);
            // 
            // chNume
            // 
            this.chNume.Text = "Nume";
            // 
            // chOreLucrate
            // 
            this.chOreLucrate.Text = "Ore Lucrate";
            // 
            // chSalariuOrar
            // 
            this.chSalariuOrar.Text = "Salariu Orar";
            // 
            // chSalariuTotal
            // 
            this.chSalariuTotal.Text = "Salariu Total";
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(594, 256);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(75, 23);
            this.btnAfiseaza.TabIndex = 5;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // tbFirme
            // 
            this.tbFirme.Location = new System.Drawing.Point(159, 280);
            this.tbFirme.Multiline = true;
            this.tbFirme.Name = "tbFirme";
            this.tbFirme.Size = new System.Drawing.Size(279, 128);
            this.tbFirme.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbFirme);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.listViewAngajati);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbSalariuOrar);
            this.Controls.Add(this.tbOreLucrate);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbOreLucrate;
        private System.Windows.Forms.TextBox tbSalariuOrar;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ListView listViewAngajati;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chOreLucrate;
        private System.Windows.Forms.ColumnHeader chSalariuOrar;
        private System.Windows.Forms.ColumnHeader chSalariuTotal;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.TextBox tbFirme;
    }
}

