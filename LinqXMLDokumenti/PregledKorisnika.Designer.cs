namespace LinqXMLDokumenti
{
    partial class PregledKorisnika
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.rtbPregled = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPregledKorisnika = new System.Windows.Forms.Button();
            this.chbIme = new System.Windows.Forms.CheckBox();
            this.chbPrezime = new System.Windows.Forms.CheckBox();
            this.chbKorisnikID = new System.Windows.Forms.CheckBox();
            this.chbAdresa = new System.Windows.Forms.CheckBox();
            this.chbEmail = new System.Windows.Forms.CheckBox();
            this.chbBrojTelf = new System.Windows.Forms.CheckBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtKorisnikID = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBrojTelf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(160, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 63);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pregled korisnika";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(128, 107);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(213, 29);
            this.txtIme.TabIndex = 23;
            // 
            // rtbPregled
            // 
            this.rtbPregled.Location = new System.Drawing.Point(18, 365);
            this.rtbPregled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbPregled.Name = "rtbPregled";
            this.rtbPregled.Size = new System.Drawing.Size(740, 284);
            this.rtbPregled.TabIndex = 24;
            this.rtbPregled.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(152, 334);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ispis podataka o korisniku i o posudbama";
            // 
            // btnPregledKorisnika
            // 
            this.btnPregledKorisnika.Location = new System.Drawing.Point(423, 238);
            this.btnPregledKorisnika.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPregledKorisnika.Name = "btnPregledKorisnika";
            this.btnPregledKorisnika.Size = new System.Drawing.Size(180, 35);
            this.btnPregledKorisnika.TabIndex = 26;
            this.btnPregledKorisnika.Text = "Pregled";
            this.btnPregledKorisnika.UseVisualStyleBackColor = true;
            this.btnPregledKorisnika.Click += new System.EventHandler(this.btnPregledKorisnika_Click);
            // 
            // chbIme
            // 
            this.chbIme.AutoSize = true;
            this.chbIme.Location = new System.Drawing.Point(13, 112);
            this.chbIme.Name = "chbIme";
            this.chbIme.Size = new System.Drawing.Size(62, 24);
            this.chbIme.TabIndex = 27;
            this.chbIme.Text = "Ime";
            this.chbIme.UseVisualStyleBackColor = true;
            // 
            // chbPrezime
            // 
            this.chbPrezime.AutoSize = true;
            this.chbPrezime.Location = new System.Drawing.Point(13, 156);
            this.chbPrezime.Name = "chbPrezime";
            this.chbPrezime.Size = new System.Drawing.Size(92, 24);
            this.chbPrezime.TabIndex = 28;
            this.chbPrezime.Text = "Prezime";
            this.chbPrezime.UseVisualStyleBackColor = true;
            // 
            // chbKorisnikID
            // 
            this.chbKorisnikID.AutoSize = true;
            this.chbKorisnikID.Location = new System.Drawing.Point(13, 196);
            this.chbKorisnikID.Name = "chbKorisnikID";
            this.chbKorisnikID.Size = new System.Drawing.Size(116, 24);
            this.chbKorisnikID.TabIndex = 29;
            this.chbKorisnikID.Text = "Korisnik_ID";
            this.chbKorisnikID.UseVisualStyleBackColor = true;
            // 
            // chbAdresa
            // 
            this.chbAdresa.AutoSize = true;
            this.chbAdresa.Location = new System.Drawing.Point(12, 238);
            this.chbAdresa.Name = "chbAdresa";
            this.chbAdresa.Size = new System.Drawing.Size(86, 24);
            this.chbAdresa.TabIndex = 30;
            this.chbAdresa.Text = "Adresa";
            this.chbAdresa.UseVisualStyleBackColor = true;
            // 
            // chbEmail
            // 
            this.chbEmail.AutoSize = true;
            this.chbEmail.Location = new System.Drawing.Point(366, 112);
            this.chbEmail.Name = "chbEmail";
            this.chbEmail.Size = new System.Drawing.Size(74, 24);
            this.chbEmail.TabIndex = 31;
            this.chbEmail.Text = "Email";
            this.chbEmail.UseVisualStyleBackColor = true;
            // 
            // chbBrojTelf
            // 
            this.chbBrojTelf.AutoSize = true;
            this.chbBrojTelf.Location = new System.Drawing.Point(366, 159);
            this.chbBrojTelf.Name = "chbBrojTelf";
            this.chbBrojTelf.Size = new System.Drawing.Size(129, 24);
            this.chbBrojTelf.TabIndex = 32;
            this.chbBrojTelf.Text = "Broj Telefona";
            this.chbBrojTelf.UseVisualStyleBackColor = true;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(128, 154);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrezime.Multiline = true;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(213, 29);
            this.txtPrezime.TabIndex = 33;
            // 
            // txtKorisnikID
            // 
            this.txtKorisnikID.Location = new System.Drawing.Point(128, 196);
            this.txtKorisnikID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKorisnikID.Multiline = true;
            this.txtKorisnikID.Name = "txtKorisnikID";
            this.txtKorisnikID.Size = new System.Drawing.Size(213, 29);
            this.txtKorisnikID.TabIndex = 34;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(128, 242);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdresa.Multiline = true;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(213, 29);
            this.txtAdresa.TabIndex = 35;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(502, 112);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 29);
            this.txtEmail.TabIndex = 36;
            // 
            // txtBrojTelf
            // 
            this.txtBrojTelf.Location = new System.Drawing.Point(502, 156);
            this.txtBrojTelf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBrojTelf.Multiline = true;
            this.txtBrojTelf.Name = "txtBrojTelf";
            this.txtBrojTelf.Size = new System.Drawing.Size(200, 29);
            this.txtBrojTelf.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "*označi po kojim sve filterima želiš tražiti korisnike";
            // 
            // PregledKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 663);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrojTelf);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtKorisnikID);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.chbBrojTelf);
            this.Controls.Add(this.chbEmail);
            this.Controls.Add(this.chbAdresa);
            this.Controls.Add(this.chbKorisnikID);
            this.Controls.Add(this.chbPrezime);
            this.Controls.Add(this.chbIme);
            this.Controls.Add(this.btnPregledKorisnika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbPregled);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PregledKorisnika";
            this.Text = "PregledKorisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.RichTextBox rtbPregled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPregledKorisnika;
        private System.Windows.Forms.CheckBox chbIme;
        private System.Windows.Forms.CheckBox chbPrezime;
        private System.Windows.Forms.CheckBox chbKorisnikID;
        private System.Windows.Forms.CheckBox chbAdresa;
        private System.Windows.Forms.CheckBox chbEmail;
        private System.Windows.Forms.CheckBox chbBrojTelf;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtKorisnikID;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBrojTelf;
        private System.Windows.Forms.Label label2;
    }
}