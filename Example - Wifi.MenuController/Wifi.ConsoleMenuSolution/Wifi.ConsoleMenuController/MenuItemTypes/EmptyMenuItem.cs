namespace Wifi.ConsoleMenuController.MenuItemTypes
{
    public class EmptyMenuItem : IMenuItem
    {
        public string Description => string.Empty;

        public char SelectionCode => ' ';

        public int Width => 0;

        public Action ExecuteAction => null;

        public void Execute() { }

        public void Display()
        {
            Console.WriteLine();
        }
    }
}
