using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Katalog : IZarzadzaniePozycjami
    {
        private string dzialTematyczny;
        public string DzialTematyczny { get { return dzialTematyczny; } }
        
        
        
        public Katalog()
        {
        }

        public Katalog(string dzialTematyczny_)
        {
            this.dzialTematyczny = dzialTematyczny_;
        }
        public List<Pozycja> poz = new List<Pozycja>();
        

        public void DodajPozycje(Pozycja pozycja)
        {
            poz.Add(pozycja);

        }

        public Pozycja ZnajdzPozycjePoTytule(string znajdzPoTytule)
        {
            foreach (Pozycja p in poz)
            {
                if (p.Tytul == znajdzPoTytule)
                {
                    p.WypiszInfo();
                }
               
            }
            return null;
        }
        
        

        public Pozycja ZnajdzPozycjePoID(int znajdzPoId)
        {
            foreach (Pozycja p in poz)
            {
                if(p.ID == znajdzPoId)  
                {
                    p.WypiszInfo();
                }
                
                
                
                
            }
            return null;
        }

        public void WypiszWszystkiePozycje()
        {
            foreach (Pozycja p in poz)
            {
                p.WypiszInfo();
            }
        }
    }
}
