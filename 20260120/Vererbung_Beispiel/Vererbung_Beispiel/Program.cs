
namespace Vererbung_Beispiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var zahl = 5;

            var randomNumberGenerator = CreateRandomGenerator();

            var randomString = randomNumberGenerator.NextString(15);
            Console.WriteLine(randomString);
        }

        private static RandomAdvanced CreateRandomGenerator()
        {
            return new RandomAdvanced();
        }
    }
}
