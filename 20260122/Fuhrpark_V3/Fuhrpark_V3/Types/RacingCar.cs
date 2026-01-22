using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_V3.Types
{    
    internal class RacingCar : Car
    {
        private DownforceType _downforceDevice;

        public RacingCar(string description, int maxSpeed, ConsoleColor color, DownforceType downforceType)
            : base(description, maxSpeed, color, 2)
        {
            _downforceDevice = downforceType;
        }

        public DownforceType DownforceDevice
        {
            get { return _downforceDevice; } 
        }

        public override void Show()
        {
            Console.WriteLine($"RacingCar airodynamic property: {_downforceDevice}");
            base.Show();
        }

    }
}
