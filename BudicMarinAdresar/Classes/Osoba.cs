using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudicMarinAdresar
{
    internal class Osoba
    {
        public int Id { get; set; }
        
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string Broj { get; set; }
        public string Ulica { get; set; }
        public string Grad { get; set; }
        
        public string PostanskiBroj { get; set; }

        public string Drzava { get; set; }
       
    }
}
