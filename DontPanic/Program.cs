using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't panic nulliga
            //programm asendab kõik 'a' t'hed lauses neljaga

            string lause = "Don't panic!";

            lause = lause.Replace('o', '0');
            lause = lause.Replace('a', '4');

            Console.WriteLine(lause);
        }
    }
}
