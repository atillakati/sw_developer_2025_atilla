using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_GL
{
    internal class Scooter : Vehicle
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

	}
}
