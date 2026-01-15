namespace Vererbung_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("VW Polo");
            Car car2 = new Car("BadMobil V12", 350, ConsoleColor.DarkBlue);
            
            

            car1.Show();
            car2.Show();

            car1.SpeedUp(100);
            car1.Show();
        }
    }
}
