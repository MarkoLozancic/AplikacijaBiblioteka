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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUnesiKorisnika
            // 
            this.btnUnesiKorisnika.Location = new System.Drawing.Point(59, 117);
            this.btnUnesiKorisnika.Name = "btnUnesiKorisnika";
            this.btnUnesiKorisnika.Size = new System.Drawing.Size(276, 88);
            this.btnUnesiKorisnika.TabIndex = 0;
            this.btnUnesiKorisnika.Text = "Unesi novog korisnika";
            this.btnUnesiKorisnika.UseVisualStyleBackColor = true;
            this.btnUnesiKorisnika.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPregledKorisnika
            // 
            this.btnPregledKorisnika.Location = new System.Drawing.Point(641, 117);
            this.btnPregledKorisnika.Name = "btnPregledKorisnika";
            this.btnPregledKorisnika.Size = new System.Drawing.Size(293, 88);
            this.btnPregledKorisnika.TabIndex = 2;
            this.btnPregledKorisnika.Text = "Pregled korisnika";
            this.btnPregledKorisnika.UseVisualStyleBackColor = true;
            this.btnPregledKorisnika.Click += new System.EventHandler(this.btnPregledKorisnika_Click);
            // 
            // btnPretraziKnjige
            // 
            this.btnPretraziKnjige.Location = new System.Drawing.Point(641, 510);
            this.btnPretraziKnjige.Name = "btnPretraziKnjige";
            this.btnPretraziKnjige.Size = new System.Drawing.Size(293, 92);
            this.btnPretraziKnjige.TabIndex = 13;
            this.btnPretraziKnjige.Text = "Pregled knjiga";
            this.btnPretraziKnjige.UseVisualStyleBackColor = true;
            this.btnPretraziKnjige.Click += new System.EventHandler(this.btnPretraziKnjige_Click);
            // 
            // btnPosudba
            // 
            this.btnPosudba.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPosudba.Location = new System.Drawing.Point(340, 316);
            this.btnPosudba.Name = "btnPosudba";
            this.btnPosudba.Size = new System.Drawing.Size(275, 92);
            this.btnPosudba.TabIndex = 14;
            this.btnPosudba.Text = "Vracanje/Posudivanje knjiga";
            this.btnPosudba.UseVisualStyleBackColor = false;
            this.btnPosudba.Click += new System.EventHandler(this.btnPosudba_Click);
            // 
            // btnUnesiKnjigu
            // 
            this.btnUnesiKnjigu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUnesiKnjigu.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnUnesiKnjigu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUnesiKnjigu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUnesiKnjigu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btnUnesiKnjigu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnesiKnjigu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnesiKnjigu.ForeColor = System.Drawing.Color.Black;
            this.btnUnesiKnjigu.Location = new System.Drawing.Point(59, 509);
            this.btnUnesiKnjigu.Name = "btnUnesiKnjigu";
            this.btnUnesiKnjigu.Size = new System.Drawing.Size(276, 93);
            this.btnUnesiKnjigu.TabIndex = 1;
            this.btnUnesiKnjigu.Text = "Unesi novu  knjigu";
            this.btnUnesiKnjigu.UseVisualStyleBackColor = false;
            this.btnUnesiKnjigu.Click += new System.EventHandler(this.btnUnesiKnjigu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(106, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 63);
            this.label1.TabIndex = 16;
            this.label1.Text = "Upravitelj knjižnice";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-15, -15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(840, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = "X";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(138, -36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 147);
            this.panel1.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(791, 68);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 28);
            this.button3.TabIndex = 20;
            this.button3.Text = "-";
            this.button3.UseCompatibleTextRendering = true;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::LinqXMLDokumenti.Properties.Resources.Salle_de_lecture_Bibliothèque_Mazarine_depuis_gallerie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1060, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPosudba);
            this.Controls.Add(this.btnPretraziKnjige);
            this.Controls.Add(this.btnPregledKorisnika);
            this.Controls.Add(this.btnUnesiKnjigu);
            this.Controls.Add(this.btnUnesiKorisnika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knjižnica";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnesiKorisnika;
        private System.Windows.Forms.Button btnPregledKorisnika;
        private System.Windows.Forms.Button btnPretraziKnjige;
        private System.Windows.Forms.Button btnPosudba;
        private System.Windows.Forms.Button btnUnesiKnjigu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
    }
}

