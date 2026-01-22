namespace Fuhrpark_V3.Types
{
    internal interface IVehicle
    {                
        int MaxSpeed { get; }        
        int CurrentSpeed { get; }
        string Description { get; }
        ConsoleColor Color { get; }

        void ChangeRadioPower(bool isOn);
        void MakeSound();
        void SpeedUp(int delta);
        void Show();        
    }
}