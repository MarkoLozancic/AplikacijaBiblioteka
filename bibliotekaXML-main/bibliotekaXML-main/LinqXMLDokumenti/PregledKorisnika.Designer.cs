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
            this.label6 = new System.Windows.Forms.Label();
            this.txtPregledKorisnika = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPregledKorisnika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 40);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pregled korisnika";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(16, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Korisnik ID";
            // 
            // txtPregledKorisnika
            // 
            this.txtPregledKorisnika.Location = new System.Drawing.Point(12, 131);
            this.txtPregledKorisnika.Multiline = true;
            this.txtPregledKorisnika.Name = "txtPregledKorisnika";
            this.txtPregledKorisnika.Size = new System.Drawing.Size(123, 20);
            this.txtPregledKorisnika.TabIndex = 23;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 237);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(495, 244);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ispis podataka o korisniku i o posudbama";
            // 
            // btnPregledKorisnika
            // 
            this.btnPregledKorisnika.Location = new System.Drawing.Point(202, 128);
            this.btnPregledKorisnika.Name = "btnPregledKorisnika";
            this.btnPregledKorisnika.Size = new System.Drawing.Size(120, 23);
            this.btnPregledKorisnika.TabIndex = 26;
            this.btnPregledKorisnika.Text = "Pregled";
            this.btnPregledKorisnika.UseVisualStyleBackColor = true;
            // 
            // PregledKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 581);
            this.Controls.Add(this.btnPregledKorisnika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtPregledKorisnika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Name = "PregledKorisnika";
            this.Text = "PregledKorisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPregledKorisnika;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPregledKorisnika;
    }
}