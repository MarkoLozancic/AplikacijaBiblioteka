using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LinqXMLDokumenti
{
    public partial class PregledKnjiga : Form
    {
        public PregledKnjiga()
        {
            InitializeComponent();
        }
       

       
        private void btnPregledKnjiga_Click(object sender, EventArgs e)
        {
            rtbPregled.Clear();
            var pregledknjiga = XDocument.Load("Knjiga.xml");

            var query =
                from Knjiga
          in  pregledknjiga.Descendants("Knjiga")
    where
     (Knjiga.Element("Naslov").Value == txtNaslov.Text&& chbNaslov.Checked) ||
      (Knjiga.Element("Autor").Value == txtAutor.Text && chbAutor.Checked) ||
      (chbIzdavac.Checked&& Knjiga.Element("Izdavac").Value == txtIzdavac.Text) ||
      (chbAutor.Checked && Knjiga.Element("Knjiga_ID").Value == txtKnjigaID.Text)         
                select Knjiga;
            query.ToList().ForEach(s => rtbPregled.AppendText("\n\n"+Convert.ToString(s)));
          
            
        }
    }
}
