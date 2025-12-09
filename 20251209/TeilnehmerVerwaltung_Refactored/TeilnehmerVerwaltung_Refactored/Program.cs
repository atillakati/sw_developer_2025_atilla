using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeilnehmerVerwaltung_Refactored
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Erfassen von Teilnehmerdaten (1x):
             * - Name
             * - Wohnort & PLZ
             * - Geburtsdatum (DateTime)
             * 
             * - User-Freundliches Design 
             * - Fehlertolerante Umsetzung der Eingaben
             * - Formatierte Zusammenfassung der Teilnehmerdaten ausgeben
             * 
             * */

            string name = string.Empty;
            string wohnort = string.Empty;
            int plz = 0;
            DateTime geburtsDatum = DateTime.MinValue;
            string userInput = string.Empty;
            bool isUserInputValid = false;


            //1. Ausgabe Header
            CreateHeader("Teilnehmer-Verwaltung v1.1");

            //2. Teilnehmerdaten erfassen
            Console.WriteLine("Bitte geben Sie folgende Teilnehmer-Daten ein:");
            Console.Write("\tName: ");
            name = Console.ReadLine();

            Console.Write("\tWohnort: ");
            wohnort = Console.ReadLine();

            plz = GetInt("\tPlz: ");
            isUserInputValid = GetDateTime(ref geburtsDatum);

            //3. Ausgabe der Daten
            Console.WriteLine("\nFolgende Daten wurden erfasst:\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t" + name);
            Console.WriteLine("\t" + plz + " " + wohnort);
            Console.WriteLine("\t" + geburtsDatum.ToLongDateString());
            Console.WriteLine();

            Console.ResetColor();
        }

        private static bool GetDateTime(ref DateTime geburtsDatum)
        {
            bool isUserInputValid;
            do
            {
                try
                {
                    Console.Write("\tGeburtsdatum (dd.mm.yyyy): ");
                    geburtsDatum = DateTime.Parse(Console.ReadLine());

                    isUserInputValid = true;
                }
                catch
                {
                    isUserInputValid = false;
                }
            }
            while (isUserInputValid == false);
            return isUserInputValid;
        }

        static int GetInt(string inputPrompt)
        {
            int inputValue = 0;
            bool isUserInputValid;

            do
            {
                try
                {
                    Console.Write(inputPrompt);
                    inputValue = int.Parse(Console.ReadLine());
                    isUserInputValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\aERROR: " + ex.Message);
                    isUserInputValid = false;
                }
            }
            while (isUserInputValid == false);
            
            return inputValue;
        }

        static void CreateHeader(string titleString)
        {
            int startPositionX = 0;
            //string headerString = "Teilnehmer-Verwaltung v1.0";

            string headerBorder = new string('#', Console.WindowWidth - 1);
            Console.WriteLine(headerBorder);
            startPositionX = (Console.WindowWidth - titleString.Length) / 2;
            Console.CursorLeft = startPositionX;
            Console.WriteLine(titleString);
            Console.WriteLine(headerBorder);
            Console.WriteLine();
        }
    
    }
}
