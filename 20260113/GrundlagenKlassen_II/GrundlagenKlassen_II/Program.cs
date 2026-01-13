using System.ComponentModel;

namespace GrundlagenKlassen_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adresse adr = new Adresse();
            Employee ma = new Employee("Max", "Muster", new DateTime(1980, 5, 15), adr);

            ma.Display();

            Console.WriteLine($"Aktuelle Gehalt: EUR {ma.Sallery.ToString("#,###.00")}");

            ma.GiveBonus(0.05);
            Console.WriteLine($"Aktuelle Gehalt: EUR {ma.Sallery.ToString("#,###.00")}");

            //ma.Sallery = 5500.90m;
            Console.WriteLine($"Aktuelle Gehalt: EUR {ma.Sallery.ToString("#,###.00")}");

            Console.WriteLine($"Name: {ma.Name}");
                                   
           
        }
    }
}
