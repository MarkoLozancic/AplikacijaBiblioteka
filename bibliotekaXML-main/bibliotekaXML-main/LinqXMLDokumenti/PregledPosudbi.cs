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
    public partial class Posudba_Vracanje : Form
    {
        public Posudba_Vracanje()
        {
            InitializeComponent();
        }

        private void btnPosudba_Vracanje_Click(object sender, EventArgs e)

        {
            var validanKorisnikID = XDocument.Load("Korisnik.xml");
            var pregledevidencije = XDocument.Load("Evidencija.xml");

            var query =
                from Evidencija
          in pregledevidencije.Descendants("Evidencija")
                where
                 Evidencija.Element("Kljuc").Value == txtKorisnikIDVracanje.Text + txtKnjiga_ID_Vracanje.Text
                select Evidencija;
            if (query.SingleOrDefault().Value == txtKorisnikIDVracanje.Text + txtKnjiga_ID_Vracanje.Text)
            {

            }
        }
    }
}
