using Wifi.ConsoleMenuController;
using Wifi.ConsoleMenuController.MenuItemTypes;

namespace Wifi.TestApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ctrl = new MenuController("DemoMenu");

            ctrl.AddItem(new MenuItem("Datei neu", 'N', null));
            ctrl.AddItem(new MenuItem("Datei laden", 'L', null));
            ctrl.AddItem(new MenuItem("Datei speichern", 'S', null));
            ctrl.AddItem(new MenuItem("Programm Ende", 'E', null));

            ctrl.Display();
        }
    }
}
