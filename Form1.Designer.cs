namespace Videobutik
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
            this.listViewKunder = new System.Windows.Forms.ListView();
            this.columnHeaderKunderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKunderFörnamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKunderEfternamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKunderPersonnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewFilmer = new System.Windows.Forms.ListView();
            this.columnHeaderFilmerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFilmerTitel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFilmerLängd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFilmerGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewUthyrt = new System.Windows.Forms.ListView();
            this.columnHeaderUthyrtID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUthyrtDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUthyrtNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUthyrtFilm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNamn = new System.Windows.Forms.TextBox();
            this.textBoxEfternamn = new System.Windows.Forms.TextBox();
            this.textBoxPersonnummer = new System.Windows.Forms.TextBox();
            this.labelNamn = new System.Windows.Forms.Label();
            this.labelEfternamn = new System.Windows.Forms.Label();
            this.labelPersonnummer = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewKunder
            // 
            this.listViewKunder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderKunderID,
            this.columnHeaderKunderFörnamn,
            this.columnHeaderKunderEfternamn,
            this.columnHeaderKunderPersonnummer});
            this.listViewKunder.FullRowSelect = true;
            this.listViewKunder.GridLines = true;
            this.listViewKunder.Location = new System.Drawing.Point(12, 12);
            this.listViewKunder.Name = "listViewKunder";
            this.listViewKunder.Size = new System.Drawing.Size(337, 204);
            this.listViewKunder.TabIndex = 0;
            this.listViewKunder.UseCompatibleStateImageBehavior = false;
            this.listViewKunder.View = System.Windows.Forms.View.Details;
            this.listViewKunder.DoubleClick += new System.EventHandler(this.listViewKunder_DoubleClick);
            // 
            // columnHeaderKunderID
            // 
            this.columnHeaderKunderID.Text = "ID";
            this.columnHeaderKunderID.Width = 24;
            // 
            // columnHeaderKunderFörnamn
            // 
            this.columnHeaderKunderFörnamn.Text = "Förnamn";
            this.columnHeaderKunderFörnamn.Width = 103;
            // 
            // columnHeaderKunderEfternamn
            // 
            this.columnHeaderKunderEfternamn.Text = "Efternamn";
            this.columnHeaderKunderEfternamn.Width = 91;
            // 
            // columnHeaderKunderPersonnummer
            // 
            this.columnHeaderKunderPersonnummer.Text = "Personnummer";
            this.columnHeaderKunderPersonnummer.Width = 114;
            // 
            // listViewFilmer
            // 
            this.listViewFilmer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFilmerID,
            this.columnHeaderFilmerTitel,
            this.columnHeaderFilmerLängd,
            this.columnHeaderFilmerGenre});
            this.listViewFilmer.FullRowSelect = true;
            this.listViewFilmer.GridLines = true;
            this.listViewFilmer.Location = new System.Drawing.Point(377, 12);
            this.listViewFilmer.Name = "listViewFilmer";
            this.listViewFilmer.Size = new System.Drawing.Size(312, 204);
            this.listViewFilmer.TabIndex = 1;
            this.listViewFilmer.UseCompatibleStateImageBehavior = false;
            this.listViewFilmer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFilmerID
            // 
            this.columnHeaderFilmerID.Text = "ID";
            this.columnHeaderFilmerID.Width = 29;
            // 
            // columnHeaderFilmerTitel
            // 
            this.columnHeaderFilmerTitel.Text = "Titel";
            this.columnHeaderFilmerTitel.Width = 134;
            // 
            // columnHeaderFilmerLängd
            // 
            this.columnHeaderFilmerLängd.Text = "Längd";
            // 
            // columnHeaderFilmerGenre
            // 
            this.columnHeaderFilmerGenre.Text = "Genre";
            this.columnHeaderFilmerGenre.Width = 84;
            // 
            // listViewUthyrt
            // 
            this.listViewUthyrt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUthyrtID,
            this.columnHeaderUthyrtDatum,
            this.columnHeaderUthyrtNamn,
            this.columnHeaderUthyrtFilm});
            this.listViewUthyrt.FullRowSelect = true;
            this.listViewUthyrt.GridLines = true;
            this.listViewUthyrt.Location = new System.Drawing.Point(12, 237);
            this.listViewUthyrt.Name = "listViewUthyrt";
            this.listViewUthyrt.Size = new System.Drawing.Size(677, 204);
            this.listViewUthyrt.TabIndex = 2;
            this.listViewUthyrt.UseCompatibleStateImageBehavior = false;
            this.listViewUthyrt.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderUthyrtID
            // 
            this.columnHeaderUthyrtID.Text = "ID";
            this.columnHeaderUthyrtID.Width = 30;
            // 
            // columnHeaderUthyrtDatum
            // 
            this.columnHeaderUthyrtDatum.Text = "Datum";
            this.columnHeaderUthyrtDatum.Width = 170;
            // 
            // columnHeaderUthyrtNamn
            // 
            this.columnHeaderUthyrtNamn.Text = "Namn";
            this.columnHeaderUthyrtNamn.Width = 211;
            // 
            // columnHeaderUthyrtFilm
            // 
            this.columnHeaderUthyrtFilm.Text = "Film";
            this.columnHeaderUthyrtFilm.Width = 259;
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.Location = new System.Drawing.Point(722, 43);
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(115, 20);
            this.textBoxNamn.TabIndex = 3;
            // 
            // textBoxEfternamn
            // 
            this.textBoxEfternamn.Location = new System.Drawing.Point(722, 90);
            this.textBoxEfternamn.Name = "textBoxEfternamn";
            this.textBoxEfternamn.Size = new System.Drawing.Size(115, 20);
            this.textBoxEfternamn.TabIndex = 4;
            // 
            // textBoxPersonnummer
            // 
            this.textBoxPersonnummer.Location = new System.Drawing.Point(722, 136);
            this.textBoxPersonnummer.Name = "textBoxPersonnummer";
            this.textBoxPersonnummer.Size = new System.Drawing.Size(115, 20);
            this.textBoxPersonnummer.TabIndex = 5;
            // 
            // labelNamn
            // 
            this.labelNamn.AutoSize = true;
            this.labelNamn.Location = new System.Drawing.Point(722, 24);
            this.labelNamn.Name = "labelNamn";
            this.labelNamn.Size = new System.Drawing.Size(38, 13);
            this.labelNamn.TabIndex = 6;
            this.labelNamn.Text = "Namn:";
            // 
            // labelEfternamn
            // 
            this.labelEfternamn.AutoSize = true;
            this.labelEfternamn.Location = new System.Drawing.Point(719, 74);
            this.labelEfternamn.Name = "labelEfternamn";
            this.labelEfternamn.Size = new System.Drawing.Size(58, 13);
            this.labelEfternamn.TabIndex = 7;
            this.labelEfternamn.Text = "Efternamn:";
            // 
            // labelPersonnummer
            // 
            this.labelPersonnummer.AutoSize = true;
            this.labelPersonnummer.Location = new System.Drawing.Point(722, 120);
            this.labelPersonnummer.Name = "labelPersonnummer";
            this.labelPersonnummer.Size = new System.Drawing.Size(80, 13);
            this.labelPersonnummer.TabIndex = 8;
            this.labelPersonnummer.Text = "Personnummer:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(722, 173);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 43);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 468);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPersonnummer);
            this.Controls.Add(this.labelEfternamn);
            this.Controls.Add(this.labelNamn);
            this.Controls.Add(this.textBoxPersonnummer);
            this.Controls.Add(this.textBoxEfternamn);
            this.Controls.Add(this.textBoxNamn);
            this.Controls.Add(this.listViewUthyrt);
            this.Controls.Add(this.listViewFilmer);
            this.Controls.Add(this.listViewKunder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewKunder;
        private System.Windows.Forms.ColumnHeader columnHeaderKunderID;
        private System.Windows.Forms.ColumnHeader columnHeaderKunderFörnamn;
        private System.Windows.Forms.ColumnHeader columnHeaderKunderEfternamn;
        private System.Windows.Forms.ColumnHeader columnHeaderKunderPersonnummer;
        private System.Windows.Forms.ListView listViewFilmer;
        private System.Windows.Forms.ColumnHeader columnHeaderFilmerID;
        private System.Windows.Forms.ColumnHeader columnHeaderFilmerTitel;
        private System.Windows.Forms.ColumnHeader columnHeaderFilmerLängd;
        private System.Windows.Forms.ColumnHeader columnHeaderFilmerGenre;
        private System.Windows.Forms.ListView listViewUthyrt;
        private System.Windows.Forms.ColumnHeader columnHeaderUthyrtID;
        private System.Windows.Forms.ColumnHeader columnHeaderUthyrtDatum;
        private System.Windows.Forms.ColumnHeader columnHeaderUthyrtNamn;
        private System.Windows.Forms.ColumnHeader columnHeaderUthyrtFilm;
        private System.Windows.Forms.TextBox textBoxNamn;
        private System.Windows.Forms.TextBox textBoxEfternamn;
        private System.Windows.Forms.TextBox textBoxPersonnummer;
        private System.Windows.Forms.Label labelNamn;
        private System.Windows.Forms.Label labelEfternamn;
        private System.Windows.Forms.Label labelPersonnummer;
        private System.Windows.Forms.Button buttonAdd;
    }
}

