namespace LinqXMLDokumenti
{
    partial class PregledKnjiga
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
            this.label = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.btnPregledKnjiga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbPregled = new System.Windows.Forms.RichTextBox();
            this.chbNaslov = new System.Windows.Forms.CheckBox();
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.chbAutor = new System.Windows.Forms.CheckBox();
            this.chbIzdavac = new System.Windows.Forms.CheckBox();
            this.chbKnjigaID = new System.Windows.Forms.CheckBox();
            this.txtKnjigaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label.Location = new System.Drawing.Point(113, 9);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(385, 63);
            this.label.TabIndex = 19;
            this.label.Text = "Pregled knjiga";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(144, 94);
            this.txtNaslov.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNaslov.Multiline = true;
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(313, 29);
            this.txtNaslov.TabIndex = 24;
            // 
            // btnPregledKnjiga
            // 
            this.btnPregledKnjiga.Location = new System.Drawing.Point(404, 282);
            this.btnPregledKnjiga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPregledKnjiga.Name = "btnPregledKnjiga";
            this.btnPregledKnjiga.Size = new System.Drawing.Size(180, 35);
            this.btnPregledKnjiga.TabIndex = 27;
            this.btnPregledKnjiga.Text = "Pretraži";
            this.btnPregledKnjiga.UseVisualStyleBackColor = true;
            this.btnPregledKnjiga.Click += new System.EventHandler(this.btnPregledKnjiga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(40, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Podatci o knjigi i evidencija";
            // 
            // rtbPregled
            // 
            this.rtbPregled.Location = new System.Drawing.Point(13, 382);
            this.rtbPregled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbPregled.Name = "rtbPregled";
            this.rtbPregled.Size = new System.Drawing.Size(571, 329);
            this.rtbPregled.TabIndex = 29;
            this.rtbPregled.Text = "";
            // 
            // chbNaslov
            // 
            this.chbNaslov.AutoSize = true;
            this.chbNaslov.Location = new System.Drawing.Point(24, 99);
            this.chbNaslov.Name = "chbNaslov";
            this.chbNaslov.Size = new System.Drawing.Size(82, 24);
            this.chbNaslov.TabIndex = 30;
            this.chbNaslov.Text = "Naslov";
            this.chbNaslov.UseVisualStyleBackColor = true;
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Location = new System.Drawing.Point(144, 172);
            this.txtIzdavac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIzdavac.Multiline = true;
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(313, 29);
            this.txtIzdavac.TabIndex = 31;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(144, 133);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutor.Multiline = true;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(313, 29);
            this.txtAutor.TabIndex = 32;
            // 
            // chbAutor
            // 
            this.chbAutor.AutoSize = true;
            this.chbAutor.Location = new System.Drawing.Point(24, 135);
            this.chbAutor.Name = "chbAutor";
            this.chbAutor.Size = new System.Drawing.Size(74, 24);
            this.chbAutor.TabIndex = 33;
            this.chbAutor.Text = "Autor";
            this.chbAutor.UseVisualStyleBackColor = true;
            // 
            // chbIzdavac
            // 
            this.chbIzdavac.AutoSize = true;
            this.chbIzdavac.Location = new System.Drawing.Point(24, 174);
            this.chbIzdavac.Name = "chbIzdavac";
            this.chbIzdavac.Size = new System.Drawing.Size(90, 24);
            this.chbIzdavac.TabIndex = 34;
            this.chbIzdavac.Text = "Izdavac";
            this.chbIzdavac.UseVisualStyleBackColor = true;
            // 
            // chbKnjigaID
            // 
            this.chbKnjigaID.AutoSize = true;
            this.chbKnjigaID.Location = new System.Drawing.Point(24, 218);
            this.chbKnjigaID.Name = "chbKnjigaID";
            this.chbKnjigaID.Size = new System.Drawing.Size(99, 24);
            this.chbKnjigaID.TabIndex = 35;
            this.chbKnjigaID.Text = "Knjiga ID";
            this.chbKnjigaID.UseVisualStyleBackColor = true;
            // 
            // txtKnjigaID
            // 
            this.txtKnjigaID.Location = new System.Drawing.Point(144, 218);
            this.txtKnjigaID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKnjigaID.Multiline = true;
            this.txtKnjigaID.Name = "txtKnjigaID";
            this.txtKnjigaID.Size = new System.Drawing.Size(313, 29);
            this.txtKnjigaID.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "*Označi po čemu sve želis da ti se pretražuju knjige";
            // 
            // PregledKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 780);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKnjigaID);
            this.Controls.Add(this.chbKnjigaID);
            this.Controls.Add(this.chbIzdavac);
            this.Controls.Add(this.chbAutor);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtIzdavac);
            this.Controls.Add(this.chbNaslov);
            this.Controls.Add(this.rtbPregled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPregledKnjiga);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PregledKnjiga";
            this.Text = "PregledKnjiga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Button btnPregledKnjiga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbPregled;
        private System.Windows.Forms.CheckBox chbNaslov;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.CheckBox chbAutor;
        private System.Windows.Forms.CheckBox chbIzdavac;
        private System.Windows.Forms.CheckBox chbKnjigaID;
        private System.Windows.Forms.TextBox txtKnjigaID;
        private System.Windows.Forms.Label label2;
    }
}