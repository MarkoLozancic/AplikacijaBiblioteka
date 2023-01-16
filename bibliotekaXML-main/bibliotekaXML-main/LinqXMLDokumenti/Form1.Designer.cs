namespace LinqXMLDokumenti
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
            this.btnUnesiKorisnika = new System.Windows.Forms.Button();
            this.btnPregledKorisnika = new System.Windows.Forms.Button();
            this.btnPretraziKnjige = new System.Windows.Forms.Button();
            this.btnPosudba = new System.Windows.Forms.Button();
            this.btnPregledPosudbi = new System.Windows.Forms.Button();
            this.btnUnesiKnjigu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUnesiKorisnika
            // 
            this.btnUnesiKorisnika.Location = new System.Drawing.Point(35, 120);
            this.btnUnesiKorisnika.Name = "btnUnesiKorisnika";
            this.btnUnesiKorisnika.Size = new System.Drawing.Size(151, 23);
            this.btnUnesiKorisnika.TabIndex = 0;
            this.btnUnesiKorisnika.Text = "Unesi novog korisnika";
            this.btnUnesiKorisnika.UseVisualStyleBackColor = true;
            this.btnUnesiKorisnika.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPregledKorisnika
            // 
            this.btnPregledKorisnika.Location = new System.Drawing.Point(321, 120);
            this.btnPregledKorisnika.Name = "btnPregledKorisnika";
            this.btnPregledKorisnika.Size = new System.Drawing.Size(141, 23);
            this.btnPregledKorisnika.TabIndex = 2;
            this.btnPregledKorisnika.Text = "Pregled korisnika";
            this.btnPregledKorisnika.UseVisualStyleBackColor = true;
            // 
            // btnPretraziKnjige
            // 
            this.btnPretraziKnjige.Location = new System.Drawing.Point(321, 213);
            this.btnPretraziKnjige.Name = "btnPretraziKnjige";
            this.btnPretraziKnjige.Size = new System.Drawing.Size(141, 23);
            this.btnPretraziKnjige.TabIndex = 13;
            this.btnPretraziKnjige.Text = "Pregled knjiga";
            this.btnPretraziKnjige.UseVisualStyleBackColor = true;
            // 
            // btnPosudba
            // 
            this.btnPosudba.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPosudba.Location = new System.Drawing.Point(177, 340);
            this.btnPosudba.Name = "btnPosudba";
            this.btnPosudba.Size = new System.Drawing.Size(157, 38);
            this.btnPosudba.TabIndex = 14;
            this.btnPosudba.Text = "Vracanje/Posudivanje knjiga";
            this.btnPosudba.UseVisualStyleBackColor = false;
            // 
            // btnPregledPosudbi
            // 
            this.btnPregledPosudbi.Location = new System.Drawing.Point(177, 263);
            this.btnPregledPosudbi.Name = "btnPregledPosudbi";
            this.btnPregledPosudbi.Size = new System.Drawing.Size(151, 23);
            this.btnPregledPosudbi.TabIndex = 15;
            this.btnPregledPosudbi.Text = "Pregled evidencije";
            this.btnPregledPosudbi.UseVisualStyleBackColor = true;
            // 
            // btnUnesiKnjigu
            // 
            this.btnUnesiKnjigu.Location = new System.Drawing.Point(35, 213);
            this.btnUnesiKnjigu.Name = "btnUnesiKnjigu";
            this.btnUnesiKnjigu.Size = new System.Drawing.Size(151, 23);
            this.btnUnesiKnjigu.TabIndex = 1;
            this.btnUnesiKnjigu.Text = "Unesi novu  knjigu";
            this.btnUnesiKnjigu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(122, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 63);
            this.label1.TabIndex = 16;
            this.label1.Text = "Knjižnica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPregledPosudbi);
            this.Controls.Add(this.btnPosudba);
            this.Controls.Add(this.btnPretraziKnjige);
            this.Controls.Add(this.btnPregledKorisnika);
            this.Controls.Add(this.btnUnesiKnjigu);
            this.Controls.Add(this.btnUnesiKorisnika);
            this.Name = "Form1";
            this.Text = "Knjižnica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnesiKorisnika;
        private System.Windows.Forms.Button btnPregledKorisnika;
        private System.Windows.Forms.Button btnPretraziKnjige;
        private System.Windows.Forms.Button btnPosudba;
        private System.Windows.Forms.Button btnPregledPosudbi;
        private System.Windows.Forms.Button btnUnesiKnjigu;
        private System.Windows.Forms.Label label1;
    }
}

