using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt ees- ja perekonnanime
            //programm kontrollib andmete pikkust eraldi 
            //programm kuvab kumb nendest on pikem, kas ees või perekonna nimi
            Console.WriteLine("Palun sisesta enda eesnimi:");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Palun sisesta enda perekonnanimi:");
            string perenimi = Console.ReadLine();

            if (eesnimi.Length > perenimi.Length)
            {
                Console.WriteLine($"Sinu eesnimi on pikem, selles on {eesnimi.Length} sümbolit.");
            }

            else if (eesnimi.Length < perenimi.Length)
            {
                Console.WriteLine($"Sinu perekonnanimi on pikem, selles on {perenimi.Length} sümbolit.");
            }

            else
            {
                Console.WriteLine($"Sinu ees- ja perekonnanimi on sama pikad, mõlemas on {eesnimi.Length} sümbolit.");
            }
        }
    }
}
