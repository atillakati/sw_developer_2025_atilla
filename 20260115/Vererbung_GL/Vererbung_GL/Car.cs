using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_GL
{
    internal class Car : Vehicle
    {
        public Car(string description, int maxSpeed, ConsoleColor color)
            : base(description, maxSpeed, color)
        {          
        }
    }
}
