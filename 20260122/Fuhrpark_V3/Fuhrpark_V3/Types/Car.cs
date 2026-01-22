using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_V3.Types
{
    internal class Car : Vehicle
    {
        private int _seatCount;        

        public Car(string description, int maxSpeed, ConsoleColor color)
            : base(description, maxSpeed, color)
        {
            _seatCount = 5;        
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
            Console.WriteLine($"  => Sitzplätze: {_seatCount}");
        }
    }
}
