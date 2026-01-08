using TeilnehmerVerwaltungMitArray.DataTypes;
using Wifi.Toolbox.Tools;

namespace TeilnehmerVerwaltungMitArray
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            bool valid = false;
            string selection = string.Empty;
            Teilnehmer[] teilnehmerListe;

            do
            {
                Console.Clear();

                //1. Ausgabe Header
                ConsoleTools.WriteAsciiArtHeader("-tver-v4.0-", ConsoleColor.Yellow);

                Console.WriteLine("\t\tDaten erfassen ......... A");
                Console.WriteLine("\t\tDaten darstellen ....... B");
                Console.WriteLine("\t\tEnde ................... Q"); //ToDo

                selection = GetMenuSelection("\nBitte wählen: ");
                if (selection.ToUpper() == "A")
                {
                    teilnehmerListe = ReadTeilnehmerFromConsole();

                    //Daten persistieren (File)
                    foreach (var teilnehmer in teilnehmerListe)
                    {
                        string filename = CreateFilename(teilnehmer);
                        WriteFile(filename, teilnehmer);

                        Console.WriteLine($"{teilnehmer.Name} in Datei {filename} gespeichert.");
                    }

                    Wait();
                }

                if (selection.ToUpper() == "B")
                {
                    teilnehmerListe = ReadTeilnehmerFromFile("meineTeilnehmerListe.csv");
                    DisplayTeilnehmerData(teilnehmerListe);

                    Wait();
                }

                if (selection.ToUpper() == "Q")
                {
                    return;
                }
            }
            while (true);
        }


        private static void Wait()
        {
            Console.Write("ENTER für weiter.");
            Console.ReadLine();
        }

        static string GetMenuSelection(string inputPrompt)
        {
            string? selection;
            bool valid;
            do
            {
                Console.Write(inputPrompt);
                selection = Console.ReadLine();

                if (string.IsNullOrEmpty(selection) || 
                    selection.Length > 1 || 
                    "ABQ".IndexOf(selection.ToUpper()) < 0)
                {
                    valid = false;
                }
                else
                {
                    valid = true;
                }
            }
            while (!valid);

            return selection;
        }


        #region Teilnehmer spezific methods
        private static Teilnehmer[] ReadTeilnehmerFromFile(string fileName)
        {
            Teilnehmer[] teilnehmerList = null;

            //get all data lines from File at once
            string[] lines = File.ReadAllLines(fileName);
            Console.WriteLine($"{lines.Length} datalines found.");

            //create array
            teilnehmerList = new Teilnehmer[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                //line => "Gandalf;12.02.1890;;;6666;Mittelerde;"
                string line = lines[i];
                string[] parts = line.Split(";");

                try
                {
                    Adresse adr = new Adresse
                    {
                        Strasse = parts[2],
                        HausNr = parts[3],
                        Plz = int.Parse(parts[4]),
                        Wohnort = parts[5]
                    };

                    teilnehmerList[i] = new Teilnehmer
                    {
                        Name = parts[0],
                        Geburtsdatum = DateTime.Parse(parts[1]),
                        Wohnadresse = adr
                    };
                }
                catch
                {
                    ConsoleTools.WriteColoredMessage($"ERROR: Problems during read process of data line: {line}", ConsoleColor.Red);
                }
            }

            return teilnehmerList;
        }

        private static Teilnehmer[] ReadTeilnehmerFromConsole()
        {
            //Deklaration 
            int count = 0;            
            Teilnehmer einTeilnehmer;
            Teilnehmer[] teilnehmerListe;

            //Abfrage Anzahl der zu erfassenden Teilnehmer
            count = ConsoleTools.GetInt("Wieviele Teilnehmer wollen Sie erfassen (0 = KEINE): ");
            if (count < 1)
            {
                return Array.Empty<Teilnehmer>();
            }

            teilnehmerListe = new Teilnehmer[count];

            Console.WriteLine("Bitte geben Sie die Teilnehmer-Daten ein:");
            for (int i = 0; i < count; i++)
            {
                //Teilnehmerdaten erfassen
                Console.WriteLine($"\nTeilnehmer {i + 1}: ");
                einTeilnehmer = GetTeilnehmerData();

                //Teilnehmer in der Liste ablegen
                teilnehmerListe[i] = einTeilnehmer;
            }

            return teilnehmerListe;
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
            Console.WriteLine();

            for (int i = 0; i < teilnehmerListToDisplay.Length; i++)
            {
                if (string.IsNullOrEmpty(teilnehmerListToDisplay[i].Name))
                {
                    continue;
                }

                DisplayTeilnehmerData(teilnehmerListToDisplay[i]);
                Console.WriteLine();
            }
        }

        private static void DisplayTeilnehmerData(Teilnehmer teilnehmerToDisplay)
        {
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine($"\tName: {teilnehmerToDisplay.Name}");
            if (!string.IsNullOrEmpty(teilnehmerToDisplay.Wohnadresse.Strasse))
            {
                Console.WriteLine("\t" + teilnehmerToDisplay.Wohnadresse.Strasse + " " + teilnehmerToDisplay.Wohnadresse.HausNr);
            }

            Console.WriteLine("\t" + teilnehmerToDisplay.Wohnadresse.Plz + " " + teilnehmerToDisplay.Wohnadresse.Wohnort);
            Console.WriteLine("\t" + teilnehmerToDisplay.Geburtsdatum.ToLongDateString());

            Console.ResetColor();
        }

        private static Teilnehmer GetTeilnehmerData()
        {
            Teilnehmer einTeilnehmer = new Teilnehmer();

            einTeilnehmer.Name = ConsoleTools.GetString("\tName: ");
            einTeilnehmer.Wohnadresse.Wohnort = ConsoleTools.GetString("\tWohnort: ");
            einTeilnehmer.Wohnadresse.Plz = ConsoleTools.GetInt("\tPlz: ");
            einTeilnehmer.Geburtsdatum = ConsoleTools.GetDateTime("\tGeburtstag (dd.mm.yyyy): ");

            return einTeilnehmer;
        }

        #endregion
    }
}
