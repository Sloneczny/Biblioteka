using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
     interface IZarzadzaniePozycjami  
    {

        public Pozycja ZnajdzPozycjePoTytule(string znajdzPoTytule);

        public Pozycja ZnajdzPozycjePoID(int znajdzPoId);

        public void WypiszWszystkiePozycje();
        
            
        

        
    }
}
