

namespace Events_Grundlagen
{
    internal class Program
    {
        static bool stopSpeedUp = false;

        static void Main(string[] args)
        {
            var myCar = new Vehicle("MyBadMobil V12");

            myCar.MaxSpeedReached += MyCar_MaxSpeedReached;
            myCar.MaxSpeedReached += MyCar_MaxSpeedReached1;

            myCar.MaxSpeedReached += DoSomething;

            while (!stopSpeedUp)
            {
                myCar.SpeedUp(20);
                myCar.Show();
            }
        }

        private static void DoSomething(object? sender, MaxSpeedReachedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void MyCar_MaxSpeedReached1(object? sender, MaxSpeedReachedEventArgs e)
        {
            if (sender is Vehicle vehicle)
            {
                //vehicle.                
            }
            
            stopSpeedUp = true;
        }

        private static void MyCar_MaxSpeedReached(object? sender, MaxSpeedReachedEventArgs e)
        {
            Console.WriteLine($"\t==> Max Speed ({e.MaxSpeed}) wurde erreicht.");
        }

        //private static void MyCar_MaxSpeedReached1(int currentSpeed, int maxSpeed)
        //{
        //    stopSpeedUp = true;
        //}

        //private static void MyCar_MaxSpeedReached(int currentSpeed, int maxSpeed)
        //{
        //    Console.WriteLine($"\t==> Max Speed ({maxSpeed}) wurde erreicht.");            
        //}
    }
}
