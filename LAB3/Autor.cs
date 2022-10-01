using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Autor : Osoba
    {
        private string narodowosc;
        public string Narodowosc { get { return narodowosc; } }
        
        
        public Autor()
        {
        }

        public Autor(string narodowosc, string imie_, string nazwisko_) : base(imie_, nazwisko_)
        {
            this.narodowosc = narodowosc;
        }
        
    }
}
