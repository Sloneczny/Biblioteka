using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Ksiazka : Pozycja 
    {
        private int liczbaStron;
        public int LiczbaStron { get { return liczbaStron; } }
        public List<Autor> autor = new List<Autor>();

        public Ksiazka()
        {
            
        }

        public Ksiazka(string tytul_, int id, string wydawnictwo_, int rokWydania_, int liczbaStron_) : base(tytul_, id, wydawnictwo_, rokWydania_)
        {
            this.liczbaStron = liczbaStron_;
        }
        
        public void DodajAutora(Autor r)
        {
            autor.Add(new Autor(r.Imie,r.Nazwisko,r.Narodowosc));


        }
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Liczba stron : " + " " + liczbaStron);
        }
    }
}
