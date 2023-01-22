using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace LinqXMLDokumenti
{
    class Stanje
    {
        int kolicina_knjiga;

        public Stanje(int kolicina_knjiga)
        {
            this.Kolicina_knjiga = kolicina_knjiga;
        }

        public int Kolicina_knjiga { get => kolicina_knjiga; set => kolicina_knjiga = value; }

        public override string ToString()
        {
            return "Kolicina: "+Kolicina_knjiga;
        }
    }
}
