using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqXMLDokumenti
{
    internal class Knjiga
    {
        int knjiga_id;
        string autor, izdavac, naslov;

        public Knjiga(int knjiga_id, string autor, string izdavac, string naslov)
        {
            this.knjiga_id = knjiga_id;
            this.autor = autor;
            this.izdavac = izdavac;
            this.naslov = naslov;
        }

        public int Knjiga_id { get => knjiga_id; set => knjiga_id = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Izdavac { get => izdavac; set => izdavac = value; }
        public string Naslov { get => naslov; set => naslov = value; }

        public override string ToString()
        {
            return "Knjiga ID: " + Knjiga_id + " Autor: " + Autor + ", Izdavac" + Izdavac + ",  Naslov: " + Naslov;
        }
    }
}
