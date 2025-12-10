using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.Toolbox.Tools
{
    public abstract class ConsoleTools
    {
        //GetDouble inkl. RangeCheck
        //GetBool
        //GetDecimal inkl. RangeCheck
        //WriteColoredMessage mit default-Color und eine ohne

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

        public static int GetInt(string inputPrompt)
        {
            return GetInt(inputPrompt, int.MinValue, int.MaxValue);
        }

        public static void CreateHeader(string titleString)
        {
            int startPositionX = 0;
            //string headerString = "Teilnehmer-Verwaltung v1.0";

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
