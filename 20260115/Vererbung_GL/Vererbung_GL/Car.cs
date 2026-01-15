namespace Vererbung_GL
{
    internal class Car
    {
        private int _maxSpeed;
        private int _currentSpeed;
        private string _description;
        private ConsoleColor _color;

        public Car()
        {
            _description = "Default description";
            _color = ConsoleColor.White;
            _currentSpeed = 0;
            _maxSpeed = 180;
        }

        public Car(string description)
        {
            _description = description;
            _color = ConsoleColor.White;
            _currentSpeed = 0;
            _maxSpeed = 180;
        }

        public Car(string description, int maxSpeed, ConsoleColor color)
        {
            _description = description;
            _maxSpeed = maxSpeed;
            _currentSpeed = 0;
            _color = color;
        }


        public int MaxSpeed
        {
            get => _maxSpeed;            
        }

        public int CurrentSpeed
        {
            get => _currentSpeed;             
        }

        public string Description 
        { 
            get => _description;             
        }

        public ConsoleColor Color 
        { 
            get => _color; 
        }
    
        public void SpeedUp(int delta)
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

        public void Show()
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = _color;

            Console.WriteLine($"{_description} [{_currentSpeed}/{_maxSpeed} km/h]");

            Console.ForegroundColor = oldColor;
        }
    }
}