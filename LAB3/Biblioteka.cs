using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Biblioteka : IZarzadzaniePozycjami
    {
        private string adres;
        public string Adres { get { return adres; } }
        public List<Bibliotekarz> bib = new List<Bibliotekarz>();
        public List<Katalog> katalog = new List<Katalog>();

        public Biblioteka(string adres)
        {
            this.adres = adres;
        }
        
        public void DodajBibliotekarza(Bibliotekarz b)
        {
            bib.Add(new Bibliotekarz(b.Imie, b.Nazwisko, b.DataZatrudnienia, b.Wynagrodzenie));
        }
        public void WypiszBibliotekarzy()
        {
            foreach (Bibliotekarz bibliotekarz in bib)
            {
                Console.WriteLine($"Imie: {bibliotekarz.Imie} Nazwisko: " +
                    $"{bibliotekarz.Nazwisko} " +
                    $"Data zatrudnienia: {bibliotekarz.DataZatrudnienia}" +
                    $" Wynagrodzenie: {bibliotekarz.Wynagrodzenie}");
            }
        }
        public void DodajKatalog(Katalog k )
        {
            katalog.Add(k);
        }
        public void DodajPozycje(Pozycja pozycja, string dzialTematyczny_)
        {
            var kat = katalog.SingleOrDefault(k => k.DzialTematyczny == dzialTematyczny_);
            kat.DodajPozycje(pozycja);


        }
        

        public Pozycja ZnajdzPozycjePoTytule(string znajdzPoTytule)
        {
            foreach (Katalog katalog in katalog)
            {
                katalog.ZnajdzPozycjePoTytule(znajdzPoTytule);
            }
            return null;

        }

        public Pozycja ZnajdzPozycjePoID(int znajdzPoId)
        {
            foreach (Katalog katalog in katalog)
            {
                katalog.ZnajdzPozycjePoID(znajdzPoId);
            }
            return null;
        }

        public void WypiszWszystkiePozycje()
        {
            foreach (Katalog katalog in katalog)
            {
                foreach (Pozycja pozycja in katalog.poz)
                {
                    Console.WriteLine($"Tytul: {pozycja.Tytul} " +
                        $"Rok wydania: {pozycja.RokWydania} " +
                        $"Wydawnictwo: {pozycja.Wydawnictwo}");
                }
            }
        }
    }
}
