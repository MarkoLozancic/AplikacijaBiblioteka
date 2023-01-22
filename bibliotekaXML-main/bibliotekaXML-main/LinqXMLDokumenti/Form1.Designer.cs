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
            this.btnUnesiKnjigu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUnesiKorisnika
            // 
            this.btnUnesiKorisnika.Location = new System.Drawing.Point(52, 185);
            this.btnUnesiKorisnika.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUnesiKorisnika.Name = "btnUnesiKorisnika";
            this.btnUnesiKorisnika.Size = new System.Drawing.Size(226, 35);
            this.btnUnesiKorisnika.TabIndex = 0;
            this.btnUnesiKorisnika.Text = "Unesi novog korisnika";
            this.btnUnesiKorisnika.UseVisualStyleBackColor = true;
            this.btnUnesiKorisnika.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPregledKorisnika
            // 
            this.btnPregledKorisnika.Location = new System.Drawing.Point(482, 185);
            this.btnPregledKorisnika.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPregledKorisnika.Name = "btnPregledKorisnika";
            this.btnPregledKorisnika.Size = new System.Drawing.Size(212, 35);
            this.btnPregledKorisnika.TabIndex = 2;
            this.btnPregledKorisnika.Text = "Pregled korisnika";
            this.btnPregledKorisnika.UseVisualStyleBackColor = true;
            this.btnPregledKorisnika.Click += new System.EventHandler(this.btnPregledKorisnika_Click);
            // 
            // btnPretraziKnjige
            // 
            this.btnPretraziKnjige.Location = new System.Drawing.Point(482, 328);
            this.btnPretraziKnjige.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPretraziKnjige.Name = "btnPretraziKnjige";
            this.btnPretraziKnjige.Size = new System.Drawing.Size(212, 35);
            this.btnPretraziKnjige.TabIndex = 13;
            this.btnPretraziKnjige.Text = "Pregled knjiga";
            this.btnPretraziKnjige.UseVisualStyleBackColor = true;
            this.btnPretraziKnjige.Click += new System.EventHandler(this.btnPretraziKnjige_Click);
            // 
            // btnPosudba
            // 
            this.btnPosudba.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPosudba.Location = new System.Drawing.Point(249, 243);
            this.btnPosudba.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPosudba.Name = "btnPosudba";
            this.btnPosudba.Size = new System.Drawing.Size(236, 58);
            this.btnPosudba.TabIndex = 14;
            this.btnPosudba.Text = "Vracanje/Posudivanje knjiga";
            this.btnPosudba.UseVisualStyleBackColor = false;
            this.btnPosudba.Click += new System.EventHandler(this.btnPosudba_Click);
            // 
            // btnUnesiKnjigu
            // 
            this.btnUnesiKnjigu.Location = new System.Drawing.Point(52, 328);
            this.btnUnesiKnjigu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUnesiKnjigu.Name = "btnUnesiKnjigu";
            this.btnUnesiKnjigu.Size = new System.Drawing.Size(226, 35);
            this.btnUnesiKnjigu.TabIndex = 1;
            this.btnUnesiKnjigu.Text = "Unesi novu  knjigu";
            this.btnUnesiKnjigu.UseVisualStyleBackColor = true;
            this.btnUnesiKnjigu.Click += new System.EventHandler(this.btnUnesiKnjigu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(183, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 91);
            this.label1.TabIndex = 16;
            this.label1.Text = "Knjižnica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPosudba);
            this.Controls.Add(this.btnPretraziKnjige);
            this.Controls.Add(this.btnPregledKorisnika);
            this.Controls.Add(this.btnUnesiKnjigu);
            this.Controls.Add(this.btnUnesiKorisnika);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button btnUnesiKnjigu;
        private System.Windows.Forms.Label label1;
    }
}

