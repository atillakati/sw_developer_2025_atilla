using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_Beispiel
{
    public class RandomAdvanced : Random
    {
        public RandomAdvanced()
            :base()
        {            
        }

        public RandomAdvanced(int seed) 
            : base(seed) 
        {            
        }


        private const int LOWER_CASE_A = 97;
        private const int LOWER_CASE_Z = 122;
        private const int UPPER_CASE_A = 65;
        private const int UPPER_CASE_Z = 90;

        public string NextString(int length)
        {
            var randomString = string.Empty;

            for (int i = 0; i < length; i++)
            {
                //Uppercase or Lowercase??
                var isUpperCase = Next(0, 2);

                if (isUpperCase == 1)
                {
                    var randomChar = Next(UPPER_CASE_A, UPPER_CASE_Z + 1);
                    randomString += (char)randomChar;
                }
                else
                {
                    var randomChar = Next(LOWER_CASE_A, LOWER_CASE_Z + 1);
                    randomString += (char)randomChar;
                } 
            }

            return randomString;
        }
    }
}
