namespace Wifi.ConsoleMenuController
{
    public interface IMenuItem
    {
        string Description { get; }
        char SelectionCode { get; }
        int Width { get; }
        Action ExecuteAction { get; }

        void Execute();
        void Display();
    }
}