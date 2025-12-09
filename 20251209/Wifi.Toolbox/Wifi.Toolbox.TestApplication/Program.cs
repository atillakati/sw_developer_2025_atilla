using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.Toolbox.Tools;

namespace Wifi.Toolbox.TestApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleTools.CreateHeader("Demo Application ConsoleTools");

            int geburtsJahr = ConsoleTools.GetInt("Bitte Geburtsjahr eingeben: ",
                DateTime.Now.Year - 150, DateTime.Now.Year - 5);
        }
    }
}
