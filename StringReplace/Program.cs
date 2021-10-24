using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Hello world!" tärnig *

            string lause = "Hello world!";

            /*for(int i = 0; i < lause.Length; i++)
            {
                lause[i] = '*'; //sõnad on muutumatud
            }*/

            lause = lause.Replace('o', '*');
            Console.WriteLine(lause);
            
        }
    }
}
