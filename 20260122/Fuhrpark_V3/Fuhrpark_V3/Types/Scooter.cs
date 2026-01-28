using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_V3.Types
{
    internal class Scooter : VehicleBase
    {
        private const int DEFAULT_MAX_SPEED = 28;
		private int _maxDistance;

        public Scooter()
            :base("Standard Scooter", DEFAULT_MAX_SPEED, ConsoleColor.Yellow)
        {
            _maxDistance = 100;    
        }

        public Scooter(int maxDistance) 
            : base("Standard Scooter", DEFAULT_MAX_SPEED, ConsoleColor.Yellow)
        {
            _maxDistance = maxDistance;
        }

        public Scooter(string description, int maxSpeed, int maxDistance)
            : base(description, maxSpeed, ConsoleColor.Yellow)
        {
            _maxDistance = maxDistance;
        }

        public int MaxDistance
        {
			get { return _maxDistance; }		
		}

        public override void Show()
        {
            //base.Show();
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = Color;

            Console.WriteLine($"Scooter: {Description} \n\t{CurrentSpeed}/{MaxSpeed} km/h \n\t{_maxDistance} km");

            Console.ForegroundColor = oldColor;
        }
	}
}
