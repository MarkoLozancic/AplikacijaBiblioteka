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
            this.dd = new System.Windows.Forms.Label();
            this.txtPregledKorisnika = new System.Windows.Forms.TextBox();
            this.btnPregledKnjiga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label.Location = new System.Drawing.Point(23, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(259, 40);
            this.label.TabIndex = 19;
            this.label.Text = "Pregled knjiga";
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dd.Location = new System.Drawing.Point(27, 97);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(75, 18);
            this.dd.TabIndex = 23;
            this.dd.Text = "Knjiga ID";
            // 
            // txtPregledKorisnika
            // 
            this.txtPregledKorisnika.Location = new System.Drawing.Point(30, 134);
            this.txtPregledKorisnika.Multiline = true;
            this.txtPregledKorisnika.Name = "txtPregledKorisnika";
            this.txtPregledKorisnika.Size = new System.Drawing.Size(123, 20);
            this.txtPregledKorisnika.TabIndex = 24;
            // 
            // btnPregledKnjiga
            // 
            this.btnPregledKnjiga.Location = new System.Drawing.Point(203, 134);
            this.btnPregledKnjiga.Name = "btnPregledKnjiga";
            this.btnPregledKnjiga.Size = new System.Drawing.Size(120, 23);
            this.btnPregledKnjiga.TabIndex = 27;
            this.btnPregledKnjiga.Text = "Pregled";
            this.btnPregledKnjiga.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Podatci o knjigi i evidencija";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 281);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(465, 280);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            // 
            // PregledKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 610);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPregledKnjiga);
            this.Controls.Add(this.txtPregledKorisnika);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.label);
            this.Name = "PregledKnjiga";
            this.Text = "PregledKnjiga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.TextBox txtPregledKorisnika;
        private System.Windows.Forms.Button btnPregledKnjiga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}