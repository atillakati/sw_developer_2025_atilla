using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EingabenGL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string eingabeAlter = string.Empty;
            int geburtsJahr = 0;
            int alter = 0;


            Console.Write("Bitte Namen eingeben: ");
            name = Console.ReadLine();

            Console.Write("Bitte Alter eingeben: ");
            eingabeAlter = Console.ReadLine();

            alter = int.Parse(eingabeAlter);

            //Berechnung
            geburtsJahr = 2025 - alter;

            Console.WriteLine("Ihr Name ist: " + name.ToUpper());
            Console.WriteLine("Dein Geburtsjahr ist: " + geburtsJahr);
        }
    }
}
