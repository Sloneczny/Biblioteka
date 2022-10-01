using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        public string Imie { get { return imie; } }
        public string Nazwisko { get { return nazwisko; } }

        public Osoba()
        {
        }

        public Osoba(string imie_, string nazwisko_)
        {
            this.imie = imie_;
            this.nazwisko = nazwisko_;
        }
    }
}
