using System;

namespace StringsAndarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm kuvab kasutaja eesnime pikkuse

            Console.WriteLine("Sisesta oma eesnimi");
            string firstName = Console.ReadLine();

            //int firstNamelenght = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");
        }
    }
}
