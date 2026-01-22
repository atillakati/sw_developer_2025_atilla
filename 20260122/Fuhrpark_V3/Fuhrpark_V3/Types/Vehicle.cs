namespace Fuhrpark_V3.Types
{
    internal class Vehicle
    {
        private int _maxSpeed;
        private int _currentSpeed;
        private string _description;
        private ConsoleColor _color;
        private Radio _radio;
    
        public Vehicle(string description)
        {
            _description = description;
            _color = ConsoleColor.White;
            _currentSpeed = 0;
            _maxSpeed = 180;
            _radio = new Radio();
        }

        public Vehicle(string description, int maxSpeed, ConsoleColor color)
        {
            _description = description;
            _maxSpeed = maxSpeed;
            _currentSpeed = 0;
            _color = color;
            _radio = new Radio();
        }
        
        
        public int MaxSpeed
        {
            get => _maxSpeed;            
        }

        public int CurrentSpeed
        {
            get => _currentSpeed;             
        }

        public virtual string Description 
        { 
            get => _description;             
        }

        public ConsoleColor Color 
        { 
            get => _color; 
        }

        public void ChangeRadioPower(bool isOn)
        {
            if (isOn)
            {
                _radio.PowerStatus = PowerState.On;
            }
            else
            {
                _radio.PowerStatus = PowerState.Off;
            }
        }

        public void MakeSound()
        {
            _radio.MakeNoise();
        }

        public virtual void SpeedUp(int delta)
        {
            _currentSpeed += delta;

            if(_currentSpeed < 0)
            {
                _currentSpeed = 0;
            }

            if (_currentSpeed > _maxSpeed) 
            { 
                _currentSpeed = _maxSpeed;
            }
        }

        public virtual void Show()
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = _color;

            Console.WriteLine($"{_description} [{_currentSpeed}/{_maxSpeed} km/h]");

            Console.ForegroundColor = oldColor;
        }
    }
}