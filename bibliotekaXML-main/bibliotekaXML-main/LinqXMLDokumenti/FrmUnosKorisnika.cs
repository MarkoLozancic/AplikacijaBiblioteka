using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LinqXMLDokumenti
{
    public partial class FrmUnosKorisnika : Form
    {
      //  List<Osoba> osobe = new List<Osoba>();
        
        public FrmUnosKorisnika()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            List<Korisnik> Korisnici = new List<Korisnik>();
            Korisnik os = new Korisnik(Convert.ToInt32(txtKorisnikID.Text), txtEmail.Text, txtIme.Text, txtPrezime.Text, txtAdresa.Text, Convert.ToInt32(txtBrojTelf.Text));

          
                Korisnici.Add(os);
                var users = XDocument.Load(@"C:\Users\marko\source\repos\MarkoLozancic\AplikacijaBiblioteka\bibliotekaXML-main\bibliotekaXML-main\LinqXMLDokumenti\XMLFile1.xml");

                foreach (Korisnik korisnik in Korisnici)
                {
                    var Osoba = new XElement("Korisnik",
                         new XElement("Korisnik_ID", os.Korisnik_id),
                          new XElement("Email", os.Email),
                        new XElement("Ime", os.Ime),
                          new XElement("Prezime", os.Prezime),
                           new XElement("Adresa", os.Adresa),
                            new XElement("Broj_Telefona", os.BrojTelefona));

                    users.Root.Element("korisnici").Add(Osoba);
                    users.Save(@"C:\Users\marko\source\repos\MarkoLozancic\AplikacijaBiblioteka\bibliotekaXML-main\bibliotekaXML-main\LinqXMLDokumenti\XMLFile1.xml");
                    
                }
                Korisnici.Clear();
          
            txtAdresa.Clear();
            txtIme.Clear();
            txtPrezime.Clear();
            txtBrojTelf.Clear();
            txtEmail.Clear();
            txtKorisnikID.Clear();

        } 

                
                    
                
                
               
               
              
                 
            
          
        

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

