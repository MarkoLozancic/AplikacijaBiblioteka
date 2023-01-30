using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqXMLDokumenti
{
    class Evidencija
    {
        long kljuc;
        DateTime podizanje = new DateTime();
        DateTime vracanje = new DateTime();
        bool posudena;


      /*  , DateTime podizanje, DateTime vracanje, bool posudena
             this.Kljuc = kljuc;
            this.Podizanje = podizanje;
            this.Vracanje = vracanje;
            this.Posudena = posudena;*/
        public Evidencija(long kljuc)
        {
            this.Kljuc = kljuc;
        }

     

        public long Kljuc { get => kljuc; set => kljuc = value; }
        public DateTime Podizanje { get => podizanje; set => podizanje = value; }
        public DateTime Vracanje { get => vracanje; set => vracanje = value; }
        public bool Posudena { get => posudena; set => posudena = value; }

        
    }
}
