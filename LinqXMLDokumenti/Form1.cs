using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqXMLDokumenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)

        {
            FrmUnosKorisnika unos_Korisnika = new FrmUnosKorisnika();
            unos_Korisnika.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPretraziKnjige_Click(object sender, EventArgs e)
        {
            PregledKnjiga pregled_Knjiga = new PregledKnjiga();
            pregled_Knjiga.Show();

          


           
        }

        private void btnPregledKorisnika_Click(object sender, EventArgs e)
        {
            PregledKorisnika pregled_Korisnika = new PregledKorisnika();
            pregled_Korisnika.Show();
        }

        private void btnUnesiKnjigu_Click(object sender, EventArgs e)
        {
            UnosKnjige unos_Knjiga = new UnosKnjige();
            unos_Knjiga.Show();
        }

        private void btnPosudba_Click(object sender, EventArgs e)
        {
            Posudba_Vracanje posudba_vracanje = new Posudba_Vracanje();
            posudba_vracanje.Show();
        }
    }
}
