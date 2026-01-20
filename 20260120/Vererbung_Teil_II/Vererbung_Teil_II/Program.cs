using Vererbung_Teil_II.Types;

namespace Vererbung_Teil_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myScooter = new Scooter();

            myScooter.ChangeRadioPower(true);
            myScooter.MakeSound();
        }
    }
}
