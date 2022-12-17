namespace Inlämningsuppgift_2
{
    partial class FrmSäljResultat
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
            this.GrbxSäljare = new System.Windows.Forms.GroupBox();
            this.tbxAntalRegistrerade = new System.Windows.Forms.TextBox();
            this.LblAntalRegistrerade = new System.Windows.Forms.Label();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.tbxSåldaArtiklar = new System.Windows.Forms.TextBox();
            this.tbxDistrikt = new System.Windows.Forms.TextBox();
            this.tbxPersNr = new System.Windows.Forms.TextBox();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.LblSåldaArtiklar = new System.Windows.Forms.Label();
            this.LblDistrikt = new System.Windows.Forms.Label();
            this.LblPersNr = new System.Windows.Forms.Label();
            this.LblNamn = new System.Windows.Forms.Label();
            this.LblResultNamn = new System.Windows.Forms.Label();
            this.LblResultPersNr = new System.Windows.Forms.Label();
            this.LblResultDistrikt = new System.Windows.Forms.Label();
            this.LblResultSåldaArtiklar = new System.Windows.Forms.Label();
            this.tbxResultat = new System.Windows.Forms.TextBox();
            this.GrBxResultat = new System.Windows.Forms.GroupBox();
            this.btnAvsluta = new System.Windows.Forms.Button();
            this.btnRensa = new System.Windows.Forms.Button();
            this.btnVisaResultat = new System.Windows.Forms.Button();
            this.GrbxSäljare.SuspendLayout();
            this.GrBxResultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbxSäljare
            // 
            this.GrbxSäljare.Controls.Add(this.tbxAntalRegistrerade);
            this.GrbxSäljare.Controls.Add(this.LblAntalRegistrerade);
            this.GrbxSäljare.Controls.Add(this.btnLäggTill);
            this.GrbxSäljare.Controls.Add(this.tbxSåldaArtiklar);
            this.GrbxSäljare.Controls.Add(this.tbxDistrikt);
            this.GrbxSäljare.Controls.Add(this.tbxPersNr);
            this.GrbxSäljare.Controls.Add(this.tbxNamn);
            this.GrbxSäljare.Controls.Add(this.LblSåldaArtiklar);
            this.GrbxSäljare.Controls.Add(this.LblDistrikt);
            this.GrbxSäljare.Controls.Add(this.LblPersNr);
            this.GrbxSäljare.Controls.Add(this.LblNamn);
            this.GrbxSäljare.Location = new System.Drawing.Point(16, 15);
            this.GrbxSäljare.Margin = new System.Windows.Forms.Padding(4);
            this.GrbxSäljare.Name = "GrbxSäljare";
            this.GrbxSäljare.Padding = new System.Windows.Forms.Padding(4);
            this.GrbxSäljare.Size = new System.Drawing.Size(392, 256);
            this.GrbxSäljare.TabIndex = 0;
            this.GrbxSäljare.TabStop = false;
            this.GrbxSäljare.Text = "Säljare";
            // 
            // tbxAntalRegistrerade
            // 
            this.tbxAntalRegistrerade.Location = new System.Drawing.Point(167, 217);
            this.tbxAntalRegistrerade.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAntalRegistrerade.Name = "tbxAntalRegistrerade";
            this.tbxAntalRegistrerade.ReadOnly = true;
            this.tbxAntalRegistrerade.Size = new System.Drawing.Size(68, 22);
            this.tbxAntalRegistrerade.TabIndex = 10;
            // 
            // LblAntalRegistrerade
            // 
            this.LblAntalRegistrerade.AutoSize = true;
            this.LblAntalRegistrerade.Location = new System.Drawing.Point(19, 220);
            this.LblAntalRegistrerade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAntalRegistrerade.Name = "LblAntalRegistrerade";
            this.LblAntalRegistrerade.Size = new System.Drawing.Size(125, 17);
            this.LblAntalRegistrerade.TabIndex = 9;
            this.LblAntalRegistrerade.Text = "Antal registrerade:";
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(245, 164);
            this.btnLäggTill.Margin = new System.Windows.Forms.Padding(4);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(93, 28);
            this.btnLäggTill.TabIndex = 8;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // tbxSåldaArtiklar
            // 
            this.tbxSåldaArtiklar.Location = new System.Drawing.Point(192, 134);
            this.tbxSåldaArtiklar.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSåldaArtiklar.Name = "tbxSåldaArtiklar";
            this.tbxSåldaArtiklar.Size = new System.Drawing.Size(192, 22);
            this.tbxSåldaArtiklar.TabIndex = 7;
            // 
            // tbxDistrikt
            // 
            this.tbxDistrikt.Location = new System.Drawing.Point(192, 102);
            this.tbxDistrikt.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDistrikt.Name = "tbxDistrikt";
            this.tbxDistrikt.Size = new System.Drawing.Size(192, 22);
            this.tbxDistrikt.TabIndex = 6;
            // 
            // tbxPersNr
            // 
            this.tbxPersNr.Location = new System.Drawing.Point(192, 70);
            this.tbxPersNr.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPersNr.Name = "tbxPersNr";
            this.tbxPersNr.Size = new System.Drawing.Size(192, 22);
            this.tbxPersNr.TabIndex = 5;
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(192, 38);
            this.tbxNamn.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(192, 22);
            this.tbxNamn.TabIndex = 4;
            // 
            // LblSåldaArtiklar
            // 
            this.LblSåldaArtiklar.AutoSize = true;
            this.LblSåldaArtiklar.Location = new System.Drawing.Point(13, 137);
            this.LblSåldaArtiklar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSåldaArtiklar.Name = "LblSåldaArtiklar";
            this.LblSåldaArtiklar.Size = new System.Drawing.Size(129, 17);
            this.LblSåldaArtiklar.TabIndex = 3;
            this.LblSåldaArtiklar.Text = "Antal sålda artiklar:";
            // 
            // LblDistrikt
            // 
            this.LblDistrikt.AutoSize = true;
            this.LblDistrikt.Location = new System.Drawing.Point(13, 105);
            this.LblDistrikt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDistrikt.Name = "LblDistrikt";
            this.LblDistrikt.Size = new System.Drawing.Size(55, 17);
            this.LblDistrikt.TabIndex = 2;
            this.LblDistrikt.Text = "Distrikt:";
            // 
            // LblPersNr
            // 
            this.LblPersNr.AutoSize = true;
            this.LblPersNr.Location = new System.Drawing.Point(13, 73);
            this.LblPersNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPersNr.Name = "LblPersNr";
            this.LblPersNr.Size = new System.Drawing.Size(174, 17);
            this.LblPersNr.TabIndex = 1;
            this.LblPersNr.Text = "Personnummer(10 siffror):";
            // 
            // LblNamn
            // 
            this.LblNamn.AutoSize = true;
            this.LblNamn.Location = new System.Drawing.Point(13, 41);
            this.LblNamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNamn.Name = "LblNamn";
            this.LblNamn.Size = new System.Drawing.Size(49, 17);
            this.LblNamn.TabIndex = 0;
            this.LblNamn.Text = "Namn:";
            // 
            // LblResultNamn
            // 
            this.LblResultNamn.AutoSize = true;
            this.LblResultNamn.Location = new System.Drawing.Point(20, 31);
            this.LblResultNamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblResultNamn.Name = "LblResultNamn";
            this.LblResultNamn.Size = new System.Drawing.Size(45, 17);
            this.LblResultNamn.TabIndex = 1;
            this.LblResultNamn.Text = "Namn";
            // 
            // LblResultPersNr
            // 
            this.LblResultPersNr.AutoSize = true;
            this.LblResultPersNr.Location = new System.Drawing.Point(216, 31);
            this.LblResultPersNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblResultPersNr.Name = "LblResultPersNr";
            this.LblResultPersNr.Size = new System.Drawing.Size(104, 17);
            this.LblResultPersNr.TabIndex = 2;
            this.LblResultPersNr.Text = "Personnummer";
            // 
            // LblResultDistrikt
            // 
            this.LblResultDistrikt.AutoSize = true;
            this.LblResultDistrikt.Location = new System.Drawing.Point(408, 31);
            this.LblResultDistrikt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblResultDistrikt.Name = "LblResultDistrikt";
            this.LblResultDistrikt.Size = new System.Drawing.Size(51, 17);
            this.LblResultDistrikt.TabIndex = 3;
            this.LblResultDistrikt.Text = "Distrikt";
            // 
            // LblResultSåldaArtiklar
            // 
            this.LblResultSåldaArtiklar.AutoSize = true;
            this.LblResultSåldaArtiklar.Location = new System.Drawing.Point(533, 31);
            this.LblResultSåldaArtiklar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblResultSåldaArtiklar.Name = "LblResultSåldaArtiklar";
            this.LblResultSåldaArtiklar.Size = new System.Drawing.Size(92, 17);
            this.LblResultSåldaArtiklar.TabIndex = 4;
            this.LblResultSåldaArtiklar.Text = "Sålda Artiklar";
            // 
            // tbxResultat
            // 
            this.tbxResultat.Location = new System.Drawing.Point(24, 53);
            this.tbxResultat.Margin = new System.Windows.Forms.Padding(4);
            this.tbxResultat.Multiline = true;
            this.tbxResultat.Name = "tbxResultat";
            this.tbxResultat.ReadOnly = true;
            this.tbxResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxResultat.Size = new System.Drawing.Size(670, 330);
            this.tbxResultat.TabIndex = 5;
            // 
            // GrBxResultat
            // 
            this.GrBxResultat.Controls.Add(this.tbxResultat);
            this.GrBxResultat.Controls.Add(this.LblResultSåldaArtiklar);
            this.GrBxResultat.Controls.Add(this.LblResultNamn);
            this.GrBxResultat.Controls.Add(this.LblResultDistrikt);
            this.GrBxResultat.Controls.Add(this.LblResultPersNr);
            this.GrBxResultat.Location = new System.Drawing.Point(448, 15);
            this.GrBxResultat.Margin = new System.Windows.Forms.Padding(4);
            this.GrBxResultat.Name = "GrBxResultat";
            this.GrBxResultat.Padding = new System.Windows.Forms.Padding(4);
            this.GrBxResultat.Size = new System.Drawing.Size(718, 411);
            this.GrBxResultat.TabIndex = 6;
            this.GrBxResultat.TabStop = false;
            this.GrBxResultat.Text = "Resultat";
            // 
            // btnAvsluta
            // 
            this.btnAvsluta.Location = new System.Drawing.Point(153, 372);
            this.btnAvsluta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvsluta.Name = "btnAvsluta";
            this.btnAvsluta.Size = new System.Drawing.Size(127, 32);
            this.btnAvsluta.TabIndex = 7;
            this.btnAvsluta.Text = "Avsluta";
            this.btnAvsluta.UseVisualStyleBackColor = true;
            this.btnAvsluta.Click += new System.EventHandler(this.btnAvsluta_Click);
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(153, 332);
            this.btnRensa.Margin = new System.Windows.Forms.Padding(4);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(127, 32);
            this.btnRensa.TabIndex = 11;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click);
            // 
            // btnVisaResultat
            // 
            this.btnVisaResultat.Location = new System.Drawing.Point(153, 293);
            this.btnVisaResultat.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisaResultat.Name = "btnVisaResultat";
            this.btnVisaResultat.Size = new System.Drawing.Size(127, 32);
            this.btnVisaResultat.TabIndex = 8;
            this.btnVisaResultat.Text = "Visa resultat";
            this.btnVisaResultat.UseVisualStyleBackColor = true;
            this.btnVisaResultat.Click += new System.EventHandler(this.btnVisaResultat_Click);
            // 
            // FrmSäljResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.btnVisaResultat);
            this.Controls.Add(this.btnAvsluta);
            this.Controls.Add(this.GrBxResultat);
            this.Controls.Add(this.GrbxSäljare);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSäljResultat";
            this.Text = "Säljresultat";
            this.GrbxSäljare.ResumeLayout(false);
            this.GrbxSäljare.PerformLayout();
            this.GrBxResultat.ResumeLayout(false);
            this.GrBxResultat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbxSäljare;
        private System.Windows.Forms.TextBox tbxSåldaArtiklar;
        private System.Windows.Forms.TextBox tbxDistrikt;
        private System.Windows.Forms.TextBox tbxPersNr;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.Label LblSåldaArtiklar;
        private System.Windows.Forms.Label LblDistrikt;
        private System.Windows.Forms.Label LblPersNr;
        private System.Windows.Forms.Label LblNamn;
        private System.Windows.Forms.TextBox tbxAntalRegistrerade;
        private System.Windows.Forms.Label LblAntalRegistrerade;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.Label LblResultNamn;
        private System.Windows.Forms.Label LblResultPersNr;
        private System.Windows.Forms.Label LblResultDistrikt;
        private System.Windows.Forms.Label LblResultSåldaArtiklar;
        private System.Windows.Forms.TextBox tbxResultat;
        private System.Windows.Forms.GroupBox GrBxResultat;
        private System.Windows.Forms.Button btnAvsluta;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.Button btnVisaResultat;
    }
}

