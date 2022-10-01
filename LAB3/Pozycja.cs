using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    abstract class Pozycja 
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;

        public string Tytul { get { return tytul; } }
        public string Wydawnictwo { get { return wydawnictwo; } }
        public int ID { get { return id; } }
        public int RokWydania { get { return rokWydania; } }

        public Pozycja()
        {
        }

        public Pozycja(string tytul_, int id_, string wydawnictwo_, int rokWydania_)
        {
            this.tytul = tytul_;
            this.id = id_;
            this.wydawnictwo = wydawnictwo_;
            this.rokWydania = rokWydania_;
        }
        public virtual void WypiszInfo()
        {
            Console.WriteLine("Tytuł:" + " " + tytul);
            Console.WriteLine("id:" + " " +id);
            Console.WriteLine("Wydawnictwo:" + " " + wydawnictwo);
            Console.WriteLine("Rok Wydania :" + " " +rokWydania);
            
    }
    }

}
