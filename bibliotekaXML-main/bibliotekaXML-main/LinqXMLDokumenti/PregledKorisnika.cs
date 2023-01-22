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
    public partial class PregledKorisnika : Form
    {
        public PregledKorisnika()
        {
            InitializeComponent();
        }

        private void btnPregledKorisnika_Click(object sender, EventArgs e)
        {
            rtbPregled.Clear();
            var pregledkorisnika = XDocument.Load(@"C:\Users\marko\source\repos\MarkoLozancic\AplikacijaBiblioteka\bibliotekaXML-main\bibliotekaXML-main\LinqXMLDokumenti\XMLFile1.xml");

            var query =
                from Korisnik
          in pregledkorisnika.Descendants("Korisnik")
                where
                 (Korisnik.Element("Ime").Value == txtIme.Text && chbIme.Checked) ||
                  (Korisnik.Element("Prezime").Value == txtPrezime.Text && chbPrezime.Checked) ||
                  (chbKorisnikID.Checked && Korisnik.Element("Korisnik_ID").Value == txtKorisnikID.Text) ||
                  (chbAdresa.Checked && Korisnik.Element("Adresa").Value == txtAdresa.Text)||
                  (Korisnik.Element("Email").Value == txtEmail.Text && chbEmail.Checked)
                  || (Korisnik.Element("Broj_Telefona").Value == txtBrojTelf.Text && chbBrojTelf.Checked)
                select Korisnik;
            query.ToList().ForEach(s => rtbPregled.AppendText("\n\n" + Convert.ToString(s)));


        }
    }
}
