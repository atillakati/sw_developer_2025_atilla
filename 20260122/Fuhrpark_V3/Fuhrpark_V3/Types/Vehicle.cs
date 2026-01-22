namespace Fuhrpark_V3.Types
{
    internal abstract class Vehicle
    {                
        public abstract int MaxSpeed { get; }
        
        public abstract int CurrentSpeed { get; }

        public abstract string Description { get; }

        public abstract ConsoleColor Color { get; }

        public abstract void ChangeRadioPower(bool isOn);
        public abstract void MakeSound();


        public abstract void SpeedUp(int delta);

        public abstract void Show();        
    }
}