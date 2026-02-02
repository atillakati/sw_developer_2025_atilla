namespace Wifi.ConsoleMenuController
{
    public class MenuController
    {
		private string _description;
		private List<IMenuItem> _menuItems;


        public MenuController(string description)
        {
            _description = description;
			_menuItems = new List<IMenuItem>();
        }

        public IEnumerable<IMenuItem> MenuItems
		{
			get { return _menuItems; }			
		}

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		public void AddItem(IMenuItem item)
		{
			_menuItems.Add(item);
		}

        public void RemoveItem(IMenuItem item)
        {
            _menuItems.Remove(item);
        }

		public void Display()
		{
            Console.WriteLine();

            foreach (var item in _menuItems)
            {
                item.Display();
            }            
        }

        public IMenuItem GetSelection(string inputPrompt)
        {
            bool unsupportedInput = true;
            IMenuItem selectedItem = null;

            do
            {
                unsupportedInput = true;

                Console.Write(inputPrompt);                
                var input = Console.ReadKey(true);
                
                foreach (var item in _menuItems)
                {
                    if (item.SelectionCode == input.KeyChar)
                    {
                        selectedItem = item;
                        unsupportedInput = false;
                        break;
                    }
                }                

                Console.WriteLine();
            }
            while(unsupportedInput);

            return selectedItem;
        }
    }
}
