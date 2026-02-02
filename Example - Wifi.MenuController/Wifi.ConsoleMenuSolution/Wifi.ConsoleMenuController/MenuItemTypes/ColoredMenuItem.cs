namespace Wifi.ConsoleMenuController.MenuItemTypes
{
    public class ColoredMenuItem : MenuItem
    {
        private ConsoleColor _itemColor;

        public ColoredMenuItem(string description, char selectionCode, Action action, ConsoleColor itemColor, int width) 
            : base(description, selectionCode, action, width)
        {
            _itemColor = itemColor;
        }

        public ColoredMenuItem(string description, char selectionCode, Action action, ConsoleColor itemColor)
            : this(description, selectionCode, action, itemColor, 25)
        {            
        }

        public ConsoleColor ItemColor => _itemColor;

        public override void Display()
        {
            ConsoleColor oldColor = Console.ForegroundColor;

            Console.ForegroundColor = _itemColor;
            base.Display();

            Console.ForegroundColor = oldColor;
        }
    }
}
