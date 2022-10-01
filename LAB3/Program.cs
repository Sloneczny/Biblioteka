using System;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteka b1 = new Biblioteka("POLSKA KSIAZKA");
            Katalog k = new Katalog("Dramat");
            Katalog k2 = new Katalog("Komedia");
            Autor a = new Autor("Niemcy", "William", "Shakespeare");
            Autor a1 = new Autor("Polska", "Kamil", "Kopek");
            Ksiazka ksiazka1 = new Ksiazka("Romeo i Julia", 1, " Nowa ERA", 195, 1555);
            Ksiazka ksiazka2 = new Ksiazka("Głupi i Głupszy", 2, "Holly", 1996, 532);

            Bibliotekarz bibliotekarz1 = new Bibliotekarz("Roman", "Kopek", "12.03.2021", 2500);
            Bibliotekarz bibliotekarz2 = new Bibliotekarz("Joanna", " Kwiatkowska", "20.03.2021 ", 5000);


            b1.DodajBibliotekarza(bibliotekarz1);
            b1.DodajBibliotekarza(bibliotekarz2);
            b1.DodajKatalog(k);
            b1.DodajKatalog(k2);
            Pozycja p2 = ksiazka2;
            Pozycja p1 = ksiazka1;
            b1.DodajPozycje(p1, "Dramat");
            b1.DodajPozycje(p2, "Komedia");
            Console.WriteLine("INFO KSIAZKI");
            Console.WriteLine("");
            ksiazka1.DodajAutora(a);
            ksiazka2.DodajAutora(a1);
            Console.WriteLine("Romeo i Julia");
            ksiazka1.WypiszInfo();
            Console.WriteLine("");
            Console.WriteLine(" Głupi i głupszy");
            ksiazka2.WypiszInfo();

            Console.WriteLine("");
            Console.WriteLine(" Wypisz BIBLIOTEKARZE");
            b1.WypiszBibliotekarzy();

            Console.WriteLine("");

            Console.WriteLine("POTytyule");
            b1.ZnajdzPozycjePoTytule("Głupi i Głupszy");

            Console.WriteLine("");
            Console.WriteLine(" POZYCJE");
            b1.WypiszWszystkiePozycje();

            Console.WriteLine("");


            Console.WriteLine("Znajdz po ID");
            b1.ZnajdzPozycjePoID(1);




            int c;
            int b;
            Console.WriteLine("podaj a");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c + b);












        }
    }
}
