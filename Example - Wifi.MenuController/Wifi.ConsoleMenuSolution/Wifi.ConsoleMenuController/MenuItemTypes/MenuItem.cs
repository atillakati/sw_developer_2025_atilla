namespace Wifi.ConsoleMenuController.MenuItemTypes
{
    public class MenuItem : IMenuItem
    {
        private string _description;
        private char _selectionCode;
        private int _width;
        private Action _executeAction;


        public MenuItem(string description, char selectionCode, Action action, int width)
        {
            _description = description;
            _selectionCode = selectionCode;
            _executeAction = action;
            _width = width;
        }

        public MenuItem(string description, char selectionCode, Action action) 
            : this(description, selectionCode, action, 25)
        { }

        public string Description => _description;

        public char SelectionCode => _selectionCode;

        public int Width => _width;

        public Action ExecuteAction => _executeAction;

        public void Execute()
        {
            if(_executeAction != null)
            {
                _executeAction();
            }
        }

        public virtual void Display()
        {
            Console.WriteLine($"{_description} {new string('.', _width - _description.Length)} {_selectionCode}");
        }
    }
}
