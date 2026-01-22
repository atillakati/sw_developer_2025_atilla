using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_V3.Types
{
    internal class Lkw : Vehicle
    {
        public override int MaxSpeed 
        {
            get { return 100; }
        }

        public override int CurrentSpeed => throw new NotImplementedException();

        public override string Description => throw new NotImplementedException();

        public override ConsoleColor Color => throw new NotImplementedException();

        public override void ChangeRadioPower(bool isOn)
        {
            throw new NotImplementedException();
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            throw new NotImplementedException();
        }

        public override void SpeedUp(int delta)
        {
            throw new NotImplementedException();
        }
    }
}
