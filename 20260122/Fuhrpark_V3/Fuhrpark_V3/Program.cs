using Fuhrpark_V3.Types;

namespace Fuhrpark_V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myVehicleList = new Vehicle[]
            {
                new Car("Fiat e500 City", 165, ConsoleColor.Magenta),
                new Scooter(),
                new Scooter("Mikey Mouse Scooter", 35, 150),
                new RacingCar("BadMobil F1 Edition", 385, ConsoleColor.Gray, DownforceType.Wings),
            };

            ShowVehicles(myVehicleList);
        }

        private static void ShowVehicles(Vehicle[] myVehicleList)
        {
            foreach (var vehicle in myVehicleList)
            {
                vehicle.Show();                           
            }
        }
    }
}
