using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechteckBsp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = 0.0;
            double height = 0.0;
            double circumference = 0.0;  // Umfang
            double area = 0.0;           // Fläche
            int startPositionX = 0;
            string headerString = "Rechtecks-Berechnungen v1.0";
            string userInput = string.Empty;

            //1. Ausgabe Header
            string headerBorder = new string('#', Console.WindowWidth - 1);
            Console.WriteLine(headerBorder);
            startPositionX = (Console.WindowWidth - headerString.Length) / 2;
            Console.CursorLeft = startPositionX;
            Console.WriteLine(headerString);
            Console.WriteLine(headerBorder);
            Console.WriteLine();

            //2. Eingabe der Rechtecks-Werte (L, B)
            Console.Write("Bitte Länge eingeben: ");
            //userInput = Console.ReadLine();
            length = double.Parse(Console.ReadLine());

            Console.Write("Bitte Höhe eingeben: ");
            //userInput = Console.ReadLine();
            height = double.Parse(Console.ReadLine());

            //3. Berechnung der Fläche Und Umfang
            circumference = 2 * (length + height);
            area = length * height;

            //4. Ausgabe Ergebnisse
            Console.WriteLine("\nUmfang: " + circumference + " mm");
            Console.WriteLine("Fläche: " + area + " mm²");


        }
    }
}
