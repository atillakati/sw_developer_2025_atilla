using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_V3.Types
{
    internal class Radio
    {
		private string _sender;
		private PowerState _powerStatus;

        public Radio()
        {
			_powerStatus = PowerState.Off;
			_sender = string.Empty;
        }

        public PowerState PowerStatus
        {
			get { return _powerStatus; }
			set { _powerStatus = value; }
		}

		public string Sender
		{
			get { return _sender; }
			set { _sender = value; }
		}

		public void MakeNoise()
		{
			if (_powerStatus == PowerState.On)
			{
                Console.WriteLine($"Spiele Musik auf '{_sender}'...");
			}
		}
	}
}
