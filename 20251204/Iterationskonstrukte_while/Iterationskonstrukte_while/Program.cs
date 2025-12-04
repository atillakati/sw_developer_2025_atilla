using System;


namespace Iterationskonstrukte_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kopfgesteuerte Schleife
            while(DateTime.Now.Hour == 18)
            {
                Console.WriteLine("Es ist noch immer 18:00 Uhr");
            }

            //fussgesteuerte Schleife
            do
            {
                Console.WriteLine("Es ist noch immer 18:00 Uhr");
            }
            while (DateTime.Now.Hour == 18);
        }
    }
}
