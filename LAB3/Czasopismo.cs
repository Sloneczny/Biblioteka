using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Czasopismo : Pozycja
    {
        private int numer;
        public int Numer { get { return numer; } }
        

        
        public Czasopismo()
        {
        }

        public Czasopismo(string tytul_, int id_, string wydawnictwo_, int rokWydania_ , int numer_) : base(tytul_, id_, wydawnictwo_, rokWydania_)
        {
            this.numer = numer_;
        }
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Numer : " + " " + numer);
        }
        

        
        
    }

}
