using Wifi.ConsoleMenuController;
using Wifi.ConsoleMenuController.MenuItemTypes;

namespace Wifi.TestApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ctrl = new MenuController("DemoMenu");

            ctrl.AddItem(new MenuItem("Datei neu", 'N', FileCreate));
            ctrl.AddItem(new MenuItem("Datei laden", 'L', FileLoad));
            ctrl.AddItem(new MenuItem("Datei speichern", 'S', FileSave));
            ctrl.AddItem(new EmptyMenuItem());
            ctrl.AddItem(new ColoredMenuItem("Programm Ende", 'E', QuitApplication, ConsoleColor.Yellow));

            ctrl.Display();
            Console.WriteLine();

            var selection = ctrl.GetSelection("Ihre Wahl: ");
            if (selection != null)
            {
                selection.Execute();
            }
        }

        //Application main-Methods

        private static void FileSave()
        {
            Console.WriteLine("\nHier werden die Daten gespeichert.....\n");
        }

        private static void FileCreate()
        {
            Console.WriteLine("\nHier wird nun eine neue Datei erzeugt....\n");
        }

        private static void FileLoad()
        {
            Console.WriteLine("\nHier werden nun die Daten geladen....\n");
        }

        private static void QuitApplication()
        {
            Console.WriteLine("Das ist das Ende!");
            Environment.Exit(0);
        }
    }
}
