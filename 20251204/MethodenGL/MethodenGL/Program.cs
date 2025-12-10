using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodenGL
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            PrintHelloWorld();

            PrintMessage("C# ist so cool!");
            PrintMessage("Hello World!");

            PrintColoredMessage("Error: Test!", ConsoleColor.Red);
            PrintColoredMessage("Hello World!", ConsoleColor.Green);
            

            double erg = Add(5.0, 10.0);
            Console.WriteLine("Ergebnis: " + erg);

        }

        static double Add(double x, double y)
        {
            double result = x + y;

            return result;
        }

        /// <summary>
        /// Stellt eine string Message farbig dar.
        /// </summary>
        /// <param name="message">Der Text der dargestellt werden soll.</param>
        /// <param name="messageColor">Die Farbe die für die Darstellung verwendet werden soll.</param>
        static void PrintColoredMessage(string message, ConsoleColor messageColor)
        {
            //save set color to be able to restore it
            ConsoleColor oldColor = Console.ForegroundColor;

            Console.ForegroundColor = messageColor;
            Console.WriteLine(message);

            Console.ForegroundColor = oldColor;
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        //Rückgabetype MethodenName ( Parameter-Liste )
        static void PrintHelloWorld()   //=Signatur
        {
            Console.WriteLine("Hello World!");
        }
    }
}
