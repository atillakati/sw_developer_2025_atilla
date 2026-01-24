

namespace Fuhrpark_V3.Types
{
    internal class Car : VehicleBase
    {        
        private int _seatCount;
        

        public Car(string description)
            :base(description, 165, ConsoleColor.White)
        {            
            _seatCount = 5;            
        }

        public Car(string description, int maxSpeed, ConsoleColor color)
            : this(description, maxSpeed, color, 5)
        {            
        }

        public Car(string description, int maxSpeed, ConsoleColor color, int seatCount)
            : base(description, maxSpeed, color)
        {            
            _seatCount = seatCount;            
        }
        
        public int SeatCount
        {
            get { return _seatCount; }
        }
        
        public override void Show()
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = Color;

            Console.WriteLine($"{Description} [{CurrentSpeed}/{MaxSpeed} km/h]");
            Console.WriteLine($"Sitzplätze: {_seatCount}" );

            Console.ForegroundColor = oldColor;
        }
    }
}
