namespace teste1
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
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.tbMedie = new System.Windows.Forms.TextBox();
            this.tbMatricol = new System.Windows.Forms.TextBox();
            this.tbMaterii = new System.Windows.Forms.TextBox();
            this.btnAdaugaStudent = new System.Windows.Forms.Button();
            this.treeViewStudenti = new System.Windows.Forms.TreeView();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbStudenti = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(54, 41);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 20);
            this.tbNume.TabIndex = 0;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(54, 68);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(100, 20);
            this.tbPrenume.TabIndex = 1;
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(54, 95);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(100, 20);
            this.tbVarsta.TabIndex = 2;
            // 
            // tbMedie
            // 
            this.tbMedie.Location = new System.Drawing.Point(54, 150);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.Size = new System.Drawing.Size(100, 20);
            this.tbMedie.TabIndex = 3;
            // 
            // tbMatricol
            // 
            this.tbMatricol.Location = new System.Drawing.Point(54, 121);
            this.tbMatricol.Name = "tbMatricol";
            this.tbMatricol.Size = new System.Drawing.Size(100, 20);
            this.tbMatricol.TabIndex = 4;
            // 
            // tbMaterii
            // 
            this.tbMaterii.Location = new System.Drawing.Point(54, 176);
            this.tbMaterii.Name = "tbMaterii";
            this.tbMaterii.Size = new System.Drawing.Size(100, 20);
            this.tbMaterii.TabIndex = 5;
            // 
            // btnAdaugaStudent
            // 
            this.btnAdaugaStudent.Location = new System.Drawing.Point(67, 202);
            this.btnAdaugaStudent.Name = "btnAdaugaStudent";
            this.btnAdaugaStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaStudent.TabIndex = 7;
            this.btnAdaugaStudent.Text = "Adauga";
            this.btnAdaugaStudent.UseVisualStyleBackColor = true;
            this.btnAdaugaStudent.Click += new System.EventHandler(this.btnAdaugaStudent_Click);
            // 
            // treeViewStudenti
            // 
            this.treeViewStudenti.Location = new System.Drawing.Point(468, 41);
            this.treeViewStudenti.Name = "treeViewStudenti";
            this.treeViewStudenti.Size = new System.Drawing.Size(320, 180);
            this.treeViewStudenti.TabIndex = 8;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(603, 227);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(75, 23);
            this.btnAfiseaza.TabIndex = 9;
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
            this.menuStrip1.TabIndex = 10;
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
            // tbStudenti
            // 
            this.tbStudenti.Location = new System.Drawing.Point(218, 229);
            this.tbStudenti.Multiline = true;
            this.tbStudenti.Name = "tbStudenti";
            this.tbStudenti.Size = new System.Drawing.Size(222, 180);
            this.tbStudenti.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbStudenti);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.treeViewStudenti);
            this.Controls.Add(this.btnAdaugaStudent);
            this.Controls.Add(this.tbMaterii);
            this.Controls.Add(this.tbMatricol);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.tbPrenume);
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
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.TextBox tbMedie;
        private System.Windows.Forms.TextBox tbMatricol;
        private System.Windows.Forms.TextBox tbMaterii;
        private System.Windows.Forms.Button btnAdaugaStudent;
        private System.Windows.Forms.TreeView treeViewStudenti;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.TextBox tbStudenti;
    }
}

