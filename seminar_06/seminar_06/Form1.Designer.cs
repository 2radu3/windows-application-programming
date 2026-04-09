namespace seminar_06
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lvStudenti = new System.Windows.Forms.ListView();
            this.Matricol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Medie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Observatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvStudenti = new System.Windows.Forms.TreeView();
            this.tbStudenti = new System.Windows.Forms.TextBox();
            this.btnPreluareLV = new System.Windows.Forms.Button();
            this.btnStergeElemLV = new System.Windows.Forms.Button();
            this.btnPopulareTV = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeElementLVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeElementTVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvStudenti
            // 
            this.lvStudenti.CheckBoxes = true;
            this.lvStudenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Matricol,
            this.Nume,
            this.Medie,
            this.Observatie});
            this.lvStudenti.GridLines = true;
            this.lvStudenti.HideSelection = false;
            this.lvStudenti.Location = new System.Drawing.Point(13, 48);
            this.lvStudenti.Name = "lvStudenti";
            this.lvStudenti.Size = new System.Drawing.Size(245, 209);
            this.lvStudenti.TabIndex = 0;
            this.lvStudenti.UseCompatibleStateImageBehavior = false;
            this.lvStudenti.View = System.Windows.Forms.View.Details;
            // 
            // tvStudenti
            // 
            this.tvStudenti.Location = new System.Drawing.Point(278, 48);
            this.tvStudenti.Name = "tvStudenti";
            this.tvStudenti.Size = new System.Drawing.Size(221, 209);
            this.tvStudenti.TabIndex = 1;
            // 
            // tbStudenti
            // 
            this.tbStudenti.Location = new System.Drawing.Point(521, 48);
            this.tbStudenti.Multiline = true;
            this.tbStudenti.Name = "tbStudenti";
            this.tbStudenti.ReadOnly = true;
            this.tbStudenti.Size = new System.Drawing.Size(245, 209);
            this.tbStudenti.TabIndex = 2;
            // 
            // btnPreluareLV
            // 
            this.btnPreluareLV.Location = new System.Drawing.Point(13, 275);
            this.btnPreluareLV.Name = "btnPreluareLV";
            this.btnPreluareLV.Size = new System.Drawing.Size(75, 30);
            this.btnPreluareLV.TabIndex = 3;
            this.btnPreluareLV.Text = "PopulareLV";
            this.btnPreluareLV.UseVisualStyleBackColor = true;
            this.btnPreluareLV.Click += new System.EventHandler(this.btnPreluareLV_Click);
            // 
            // btnStergeElemLV
            // 
            this.btnStergeElemLV.Location = new System.Drawing.Point(278, 275);
            this.btnStergeElemLV.Name = "btnStergeElemLV";
            this.btnStergeElemLV.Size = new System.Drawing.Size(108, 30);
            this.btnStergeElemLV.TabIndex = 4;
            this.btnStergeElemLV.Text = "Sterge element LV";
            this.btnStergeElemLV.UseVisualStyleBackColor = true;
            this.btnStergeElemLV.Click += new System.EventHandler(this.btnStergeElemLV_Click);
            // 
            // btnPopulareTV
            // 
            this.btnPopulareTV.Location = new System.Drawing.Point(521, 275);
            this.btnPopulareTV.Name = "btnPopulareTV";
            this.btnPopulareTV.Size = new System.Drawing.Size(75, 30);
            this.btnPopulareTV.TabIndex = 5;
            this.btnPopulareTV.Text = "Populare TV";
            this.btnPopulareTV.UseVisualStyleBackColor = true;
            this.btnPopulareTV.Click += new System.EventHandler(this.btnPopulareTV_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeElementLVToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 26);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeElementTVToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(170, 26);
            // 
            // stergeElementLVToolStripMenuItem
            // 
            this.stergeElementLVToolStripMenuItem.Name = "stergeElementLVToolStripMenuItem";
            this.stergeElementLVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stergeElementLVToolStripMenuItem.Text = "Sterge element LV";
            this.stergeElementLVToolStripMenuItem.Click += new System.EventHandler(this.stergeElementLVToolStripMenuItem_Click);
            // 
            // stergeElementTVToolStripMenuItem
            // 
            this.stergeElementTVToolStripMenuItem.Name = "stergeElementTVToolStripMenuItem";
            this.stergeElementTVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stergeElementTVToolStripMenuItem.Text = "Sterge element TV";
            this.stergeElementTVToolStripMenuItem.Click += new System.EventHandler(this.stergeElementTVToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPopulareTV);
            this.Controls.Add(this.btnStergeElemLV);
            this.Controls.Add(this.btnPreluareLV);
            this.Controls.Add(this.tbStudenti);
            this.Controls.Add(this.tvStudenti);
            this.Controls.Add(this.lvStudenti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvStudenti;
        private System.Windows.Forms.ColumnHeader Matricol;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Medie;
        private System.Windows.Forms.ColumnHeader Observatie;
        private System.Windows.Forms.TreeView tvStudenti;
        private System.Windows.Forms.TextBox tbStudenti;
        private System.Windows.Forms.Button btnPreluareLV;
        private System.Windows.Forms.Button btnStergeElemLV;
        private System.Windows.Forms.Button btnPopulareTV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeElementLVToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem stergeElementTVToolStripMenuItem;
    }
}

