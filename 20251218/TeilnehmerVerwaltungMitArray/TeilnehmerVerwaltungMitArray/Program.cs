using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeilnehmerVerwaltungMitArray.DataTypes;

namespace TeilnehmerVerwaltungMitArray
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            bool valid = false;
            string selection = string.Empty;

            //1. Ausgabe Header
            CreateHeader("Teilnehmer-Verwaltung v4.0");
            
            Console.WriteLine("\t\tDaten erfassen ......... A");
            Console.WriteLine("\t\tDaten darstellen ....... B");
            Console.WriteLine("\t\tEnde ................... Q");  //ToDo

            //ToDo: Extract this section into a new method
            do
            {
                Console.Write("Bitte wählen: ");
                selection = Console.ReadLine();

                if (string.IsNullOrEmpty(selection) || 
                    selection.Length > 1 || 
                    "AB".IndexOf(selection.ToUpper()) < 0)
                {
                    valid = false;
                }
                else
                {
                    valid = true;
                }
            }
            while (!valid);

            if(selection.ToUpper() == "A")
            {
                TeilnehmerErfassen();
            }
            
            if(selection.ToUpper() == "B")
            {
                Teilnehmer[] teilnehmerListe = ReadTeilnehmerFromFile("meineTeilnehmerListe.csv");
                DisplayTeilnehmerData(teilnehmerListe);
            }                
        }

        private static Teilnehmer[] ReadTeilnehmerFromFile(string fileName)
        {
            //ToDo: Implement Einlesen von CSV Daten aus einer Datei ????
            return Array.Empty<Teilnehmer>();
        }

        private static void TeilnehmerErfassen()
        {
            //Deklaration 
            int count = 0;            
            Teilnehmer einTeilnehmer;
            Teilnehmer[] teilnehmerListe;

            //1b. Abfrage Anzahl der zu erfassenden Teilnehmer
            count = GetInt("Wieviele Teilnehmer wollen Sie erfassen (0 = ENDE): ");
            teilnehmerListe = new Teilnehmer[count];

            Console.WriteLine("Bitte geben Sie die Teilnehmer-Daten ein:");
            for (int i = 0; i < count; i++)
            {
                //2. Teilnehmerdaten erfassen
                Console.WriteLine($"\nTeilnehmer {i + 1}: ");
                einTeilnehmer = GetTeilnehmerData();

                //4. Daten persistieren (File)
                string filename = CreateFilename(einTeilnehmer);
                WriteFile(filename, einTeilnehmer);

                //neuen Teilnehmer in die Liste hinzufügen
                teilnehmerListe[i] = einTeilnehmer;
            }

            //3. Ausgabe der Daten
            Console.WriteLine("\nFolgende Daten wurden erfasst:\n");
            DisplayTeilnehmerData(teilnehmerListe);
        }

        private static void WriteFile(string filename, Teilnehmer tn)
        {
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.Write(tn.Name + ";");
                sw.Write(tn.Geburtsdatum.ToShortDateString() + ";");
                sw.Write(tn.Wohnadresse.Strasse + ";");
                sw.Write(tn.Wohnadresse.HausNr + ";");
                sw.Write(tn.Wohnadresse.Plz + ";");
                sw.WriteLine(tn.Wohnadresse.Wohnort + ";");                
            }
        }

        private static string CreateFilename(Teilnehmer einTeilnehmer)
        {
            //martin müller_1980.txt
            //string filename = einTeilnehmer.Name + "_" + einTeilnehmer.Geburtsdatum.Year + ".csv";

            //return filename.Replace(' ', '_');

            return "meineTeilnehmerListe.csv";
        }

        private static void DisplayTeilnehmerData(Teilnehmer[] teilnehmerListToDisplay)
        {
            for (int i = 0; i < teilnehmerListToDisplay.Length; i++)
            {
                DisplayTeilnehmerData(teilnehmerListToDisplay[i]);
                Console.WriteLine();
            }
        }

        private static void DisplayTeilnehmerData(Teilnehmer teilnehmerToDisplay)
        {
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine($"\tName: {teilnehmerToDisplay.Name}");

            Console.WriteLine("\t" + teilnehmerToDisplay.Wohnadresse.Plz + " " + teilnehmerToDisplay.Wohnadresse.Wohnort);
            Console.WriteLine("\t" + teilnehmerToDisplay.Geburtsdatum.ToLongDateString());
            Console.WriteLine();

            Console.ResetColor();
        }

        private static Teilnehmer GetTeilnehmerData()
        {
            Teilnehmer einTeilnehmer = new Teilnehmer();

            //Console.WriteLine("Bitte geben Sie folgende Teilnehmer-Daten ein:");
            Console.Write("\tName: ");
            einTeilnehmer.Name = Console.ReadLine();

            Console.Write("\tWohnort: ");
            einTeilnehmer.Wohnadresse.Wohnort = Console.ReadLine();

            einTeilnehmer.Wohnadresse.Plz = GetInt("\tPlz: ");
            einTeilnehmer.Geburtsdatum = GetDateTime("\tGeburtstag (dd.mm.yyyy): ");

            return einTeilnehmer;
        }

        static DateTime GetDateTime(string inputPrompt)
        {
            bool isUserInputValid;
            DateTime inputValue = DateTime.MinValue;

            do
            {
                try
                {
                    Console.Write(inputPrompt);
                    inputValue = DateTime.Parse(Console.ReadLine());

                    isUserInputValid = true;
                }
                catch
                {
                    isUserInputValid = false;
                }
            }
            while (isUserInputValid == false);

            return inputValue;
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
