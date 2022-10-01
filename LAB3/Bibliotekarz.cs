using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Bibliotekarz : Osoba
    {
        private string dataZatrudnienia;
        private double wynagrodzenie;
        public string DataZatrudnienia { get { return dataZatrudnienia; } }
        public double Wynagrodzenie { get { return wynagrodzenie; } }

        public Bibliotekarz()
        {
        }

        public Bibliotekarz(string imie_, string nazwisko_, string dataZatrudnienia_, double wynagrodzenie_) : base(imie_, nazwisko_)
        {
            this.dataZatrudnienia = dataZatrudnienia_;
            this.wynagrodzenie = wynagrodzenie_;
        }

        
    }
}
