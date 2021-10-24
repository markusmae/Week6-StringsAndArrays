using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja ees- ja parekonnanime
            //programm kuvab, mitu "a" tähte on kasjutana ees- ja perekonnanimes kokku
            
            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();
            
            int aCounter = 0; 

            for(int i=0; i < fullName.Length; i++)
            {
                if(fullName[i]=='a')
                {
                    aCounter++;
                }
            }

            if(aCounter !=1)
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte.");
            }

            else
            { 
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' täht.");
        }   }
    }
}
