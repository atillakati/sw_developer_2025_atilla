
namespace Vererbung_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] meinFuhrpark = new Vehicle[]
            {
                new Vehicle("VW Polo"),
                new Vehicle("Opel Astra 1.3i"),
                new Vehicle("Badmobil V12 Night Edition", 350, ConsoleColor.Green),
                new Car("Tesla Cool", 220, ConsoleColor.DarkRed),
                new Scooter()
            };

            //Fuhrpark darstellen
            DisplayVehicles(meinFuhrpark);            
        }

        private static void DisplayVehicles(Vehicle[] meinFuhrpark)
        {
            foreach (var vehicle in meinFuhrpark)
            {
                vehicle.Show();
            }
        }
    }
}
