using System;


namespace Wifi.Toolbox.Tools
{
    /// <summary>
    /// Several features to use it in a Console application
    /// </summary>
    public abstract class ConsoleTools
    {
        /// <summary>
        /// Writes a colored message to the Console. Default color is Yellow.
        /// </summary>
        /// <param name="message">The message string to write</param>        
        public static void WriteColoredMessage(string message)
        {
            WriteColoredMessage(message, ConsoleColor.Yellow);
        }

        /// <summary>
        /// Writes a colored message to the Console
        /// </summary>
        /// <param name="message">The message string to write</param>
        /// <param name="messageColor">The color the message should appear</param>
        public static void WriteColoredMessage(string message, ConsoleColor messageColor)
        {
            //save foreground color
            ConsoleColor oldColor = Console.ForegroundColor;

            Console.ForegroundColor = messageColor;
            Console.WriteLine(message);

            //restore foreground color
            Console.ForegroundColor = oldColor;
        }

        /// <summary>
        /// Returns a bool value form console input.
        /// </summary>
        /// <param name="inputPrompt">The input prompt to show to the user</param>        
        /// <returns>Returns a bool value form console input.</returns>
        /// <exception cref="ArgumentException">When min value is equal or higher than max value</exception>
        public static bool GetBool(string inputPrompt)
        {
            //1. Eingabe der Zahl
            bool inputValue = false;
            bool isUserInputValid;
            
            do
            {
                try
                {
                    Console.Write(inputPrompt);
                    inputValue = bool.Parse(Console.ReadLine());                                                         
                    isUserInputValid = true;                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\aERROR: " + ex.Message);
                    isUserInputValid = false;
                }
            }
            while (isUserInputValid == false);

            return inputValue;
        }

        /// <summary>
        /// Returns a datetime value form console input. The input format of the datetime value depends on the culture settings.
        /// </summary>
        /// <param name="inputPrompt">The input prompt to show to the user</param>        
        /// <returns>Returns a datetime value form console input.</returns>
        /// <exception cref="ArgumentException">When min value is equal or higher than max value</exception>
        public static DateTime GetDateTime(string inputPrompt)
        {
            bool isUserInputValid;
            DateTime inputValue = DateTime.MinValue;

            do
            {
                try
                {
                    Console.Write(inputPrompt);
                    inputValue = DateTime.Parse(Console.ReadLine());

                    isUserInputValid = true;
                }
                catch
                {
                    isUserInputValid = false;
                }
            }
            while (isUserInputValid == false);

            return inputValue;
        }

        /// <summary>
        /// Returns a double value form console input.
        /// </summary>
        /// <param name="inputPrompt">The input prompt to show to the user</param>        
        /// <returns>Returns a double value form console input.</returns>
        /// <exception cref="ArgumentException">When min value is equal or higher than max value</exception>
        public static double GetDouble(string inputPrompt)
        {
            return GetDouble(inputPrompt, double.MinValue, double.MaxValue);
        }

        /// <summary>
        /// Returns a double value form console input. Checks also the value range.
        /// </summary>
        /// <param name="inputPrompt">The input prompt to show to the user</param>
        /// <param name="minValue">The valid min value</param>
        /// <param name="maxValue">The valid max value</param>
        /// <returns>Returns a double value form console input.</returns>
        /// <exception cref="ArgumentException">When min value is equal or higher than max value</exception>
        public static double GetDouble(string inputPrompt, double minValue, double maxValue)
        {
            //1. Eingabe der Zahl
            double inputValue = 0.0;
            bool isUserInputValid;

            //parameter value check
            if (minValue >= maxValue)
            {
                throw new ArgumentException("Ungültiger Wertebereich definiert.");
            }

            do
            {
                try
                {
                    Console.Write(inputPrompt);
                    inputValue = double.Parse(Console.ReadLine());

                    //2. Range Check durchführen
                    if (inputValue >= minValue && inputValue <= maxValue)
                    {
                        isUserInputValid = true;
                    }
                    else
                    {
                        isUserInputValid = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\aERROR: " + ex.Message);
                    isUserInputValid = false;
                }
            }
            while (isUserInputValid == false);

            return inputValue;

        }

        /// <summary>
        /// Returns a decimal value form console input.
        /// </summary>
        /// <param name="inputPrompt">The input prompt to show to the user</param>        
        /// <returns>Returns a decimal value form console input.</returns>
        /// <exception cref="ArgumentException">When min value is equal or higher than max value</exception>
        public static decimal GetDecimal(string inputPrompt)
        {
            return GetDecimal(inputPrompt, decimal.MinValue, decimal.MaxValue);
        }

        /// <summary>
        /// Returns a decimal value form console input. Checks also the value range.
        /// </summary>
        /// <param name="inputPrompt">The input prompt to show to the user</param>
        /// <param name="minValue">The valid min value</param>
        /// <param name="maxValue">The valid max value</param>
        /// <returns>Returns a decimal value form console input.</returns>
        /// <exception cref="ArgumentException">When min value is equal or higher than max value</exception>
        public static decimal GetDecimal(string inputPrompt, decimal minValue, decimal maxValue)
        {
            //1. Eingabe der Zahl
            decimal inputValue = 0.0m;
            bool isUserInputValid;

            //parameter value check
            if (minValue >= maxValue)
            {
                throw new ArgumentException("Ungültiger Wertebereich definiert.");
            }

            do
            {
                try
                {
                    Console.Write(inputPrompt);
                    inputValue = decimal.Parse(Console.ReadLine());

                    //2. Range Check durchführen
                    if (inputValue >= minValue && inputValue <= maxValue)
                    {
                        isUserInputValid = true;
                    }
                    else
                    {
                        isUserInputValid = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\aERROR: " + ex.Message);
                    isUserInputValid = false;
                }
            }
            while (isUserInputValid == false);

            return inputValue;
        }

        /// <summary>
        /// Returns a int value form console input. Checks also the value range.
        /// </summary>
        /// <param name="inputPrompt">The input prompt to show to the user</param>
        /// <param name="minValue">The valid min value</param>
        /// <param name="maxValue">The valid max value</param>
        /// <returns>Returns a int value form console input.</returns>
        /// <exception cref="ArgumentException">When min value is equal or higher than max value</exception>
        public static int GetInt(string inputPrompt, int minValue, int maxValue)
        {
            //1. Eingabe der Zahl
            int inputValue = 0;
            bool isUserInputValid;

            //parameter value check
            if (minValue >= maxValue) 
            {
                throw new ArgumentException("Ungültiger Wertebereich definiert.");
            }

            do
            {
                try
                {
                    Console.Write(inputPrompt);
                    inputValue = int.Parse(Console.ReadLine());

                    //2. Range Check durchführen
                    if (inputValue >= minValue && inputValue <= maxValue)
                    {
                        isUserInputValid = true;
                    }
                    else
                    {
                        isUserInputValid = false;
                    }                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\aERROR: " + ex.Message);
                    isUserInputValid = false;
                }
            }
            while (isUserInputValid == false);

            return inputValue;
           
        }

        /// <summary>
        /// Returns a int value form console input.
        /// </summary>
        /// <param name="inputPrompt">The input prompt to show to the user</param>        
        /// <returns>Returns a int value form console input.</returns>
        /// <exception cref="ArgumentException">When min value is equal or higher than max value</exception>
        public static int GetInt(string inputPrompt)
        {
            return GetInt(inputPrompt, int.MinValue, int.MaxValue);
        }

        /// <summary>
        /// Creates a header with border lines. Writes the title string centered between the border lines.
        /// </summary>
        /// <param name="titleString">The title to write centered between the border lines</param>
        public static void CreateHeader(string titleString)
        {
            int startPositionX = 0;            

            string headerBorder = new string('#', Console.WindowWidth - 1);
            Console.WriteLine(headerBorder);
            startPositionX = (Console.WindowWidth - titleString.Length) / 2;
            Console.CursorLeft = startPositionX;
            Console.WriteLine(titleString);
            Console.WriteLine(headerBorder);
            Console.WriteLine();
        }
    }
}
