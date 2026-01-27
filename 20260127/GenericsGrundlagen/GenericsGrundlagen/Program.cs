


using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace GenericsGrundlagen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myNameList = CreateStringArray(15, "No Name");

            var birthdayYearList = CreateIntArray(5, 1990);

            myNameList = CreateArray<string>(4, string.Empty);

            var priceList = CreateArray(15, 0.0m);

            List<double> weightList = new List<double>();

            weightList.Add(0.5);

            Show(weightList);

            var count = GetValue<int>("Bitte Anzahl eingeben: ");
            var birthday = GetValue<DateTime>("Bitte Geburtsdatum eingeben: ");

            GetValue<Vehicle>("Test");
        }

        private static T GetValue<T>(string inputPrompt) where T : IParsable<T>   //Constraints
        {
            bool inputIsValid = false;
            T userValue = default(T);
            Type type = typeof(T);

            do
            {
                Console.Write(inputPrompt);
                try
                {
                    //var methods = type.GetMethods();
                    //foreach (var method in methods)
                    //{
                    //    Console.WriteLine(method.Name);
                    //}

                    var methode = type.GetMethod("Parse", new Type[] { typeof(string) });
                    if (methode != null)
                    {
                        userValue = (T)methode.Invoke(null, new object[] { Console.ReadLine() });
                        inputIsValid = true;
                    }

                    //userValue = int.Parse(Console.ReadLine());                    
                }
                catch 
                {
                    Console.WriteLine("ERROR: Ungültige Eingabe.");
                    inputIsValid = false;
                }
            }
            while (!inputIsValid);

            return userValue;
        }

        private static void Show(List<double> weightList)
        {
            foreach (var weight in weightList)
            {
                Console.WriteLine(weight);
            }
        }

        private static T[] CreateArray<T>(int length, T initValue)
        {
            //create the array
            var array = new T[length];            

            //initialize array values
            for (int i = 0; i < length; i++)
            {
                array[i] = initValue;
            }

            return array;
        }


        private static int[] CreateIntArray(int length, int initValue)
        {
            //create the array
            var array = new int[length];

            //initialize array values
            for (int i = 0; i < length; i++)
            {
                array[i] = initValue;
            }

            return array;
        }

        private static string[] CreateStringArray(int length, string initValue)
        {
            //create the array
            var array = new string[length];

            //initialize array values
            for (int i = 0; i < length; i++)
            {
                array[i] = initValue;
            }

            return array;
        }
    }

    public class Vehicle
    {
        public static Vehicle Parse(string s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vehicle result)
        {
            throw new NotImplementedException();
        }
    }
}
