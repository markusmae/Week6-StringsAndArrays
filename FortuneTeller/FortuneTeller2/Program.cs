using System;

namespace FortuneTeller2
{
    class Program
    {
        static void Main(string[] args)
        {
             //programm ennustab, mis kasuajaga juhtub homme(kasutame randomit)

            string[] predictions = {"win a million", "fall in love", "buy youtube premium", "join the dark side for cookies"};
            Random rnd = new Random ();

            int number = rnd.Next(0,predictions.Length);

            Console.WriteLine($"Tomorrow you will {predictions[number]}.");
        }
    }
}
