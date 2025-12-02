using System;

namespace ExceptionsGL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int height = 0;
            int circumference = 0;  // Umfang
            int area = 0;           // Fläche
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

            try
            {
                //2. Eingabe der Rechtecks-Werte (L, B)
                Console.Write("Bitte Länge eingeben: ");
                //userInput = Console.ReadLine();
                length = int.Parse(Console.ReadLine());

                Console.Write("Bitte Höhe eingeben: ");
                //userInput = Console.ReadLine();
                height = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\aERROR: Eingabe war leider keine Zahl!");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\aERROR: " + ex.Message);
                return;
            }
            finally
            {

            }
                                    
            //3. Berechnung der Fläche Und Umfang
            circumference = 2 * (length + height);
            area = length * height;

            //4. Ausgabe Ergebnisse
            Console.WriteLine("\nUmfang: " + circumference + " mm");
            Console.WriteLine("Fläche: " + area + " mm²");


        }
    }
}
