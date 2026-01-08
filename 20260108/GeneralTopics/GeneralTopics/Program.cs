namespace GeneralTopics
{
    internal class Program
    {
        //Konstanten
        const ConsoleColor DefaultForegroundColor = ConsoleColor.Cyan;
        const string APP_TITLE = "General Topics v0.2";        

        static void Main(string[] args)
        {
            Console.ForegroundColor = Program.DefaultForegroundColor;

            Console.WriteLine(Program.APP_TITLE);

            Console.Title = Program.APP_TITLE;

            Console.WriteLine("Hallo zusammen!");
            Console.ResetColor();

            //hart-kodierte Werte (hard-coded)
            for (int i = 0; i < 5; i++) 
            {

            }
            Console.ReadLine();
            //Program.DefaultForegroundColor = ConsoleColor.Yellow;

//##################################################################################################

            bool isValid = false;

            if (isValid) 
            {
                Console.WriteLine("is true");
            }
                        
        }

    }
}
