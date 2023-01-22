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
    public partial class UnosKnjige : Form
    {
        public UnosKnjige()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            List<Knjiga> Knjige = new List<Knjiga>();
            Knjiga book = new Knjiga(Convert.ToInt32(txtKnjigaID.Text), txtAutor.Text, txtIzdavac.Text, txtNaslov.Text);


            Knjige.Add(book);
            var libero = XDocument.Load(@"C:\Users\marko\source\repos\MarkoLozancic\AplikacijaBiblioteka\bibliotekaXML-main\bibliotekaXML-main\LinqXMLDokumenti\XMLFile1.xml");

            foreach (Knjiga k in Knjige)
            {
                var knjiga = new XElement("Knjiga",
                     new XElement("Knjiga_ID", book.Knjiga_id),
                      new XElement("Autor", book.Autor),
                    new XElement("Izdavac", book.Izdavac),
                      new XElement("Naslov", book.Naslov));
                       
                      

                libero.Root.Element("knjige").Add(knjiga);
                

            }
            libero.Save(@"C:\Users\marko\source\repos\MarkoLozancic\AplikacijaBiblioteka\bibliotekaXML-main\bibliotekaXML-main\LinqXMLDokumenti\XMLFile1.xml");

            Knjige.Clear();

            txtAutor.Clear();
            txtIzdavac.Clear();
            txtKnjigaID.Clear();
            txtNaslov.Clear();
           
        }
    }
}
