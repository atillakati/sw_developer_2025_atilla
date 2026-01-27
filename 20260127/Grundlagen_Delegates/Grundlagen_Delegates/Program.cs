namespace Grundlagen_Delegates
{
    internal delegate int OperationDelegate(int z1, int z2);

    internal delegate void Handler<T>(T parameter);
    internal delegate void Handler<T1, T2>(T1 parameter1, T2 paramter2);

    internal class Program
    {
        static void Main(string[] args)
        {
            OperationDelegate op;

            op = Addieren;
            Func<int, int, int> funktion = Addieren;

            var summe = Addieren(5, 8);

            summe = op(10, 15);
            Console.WriteLine("Summe: " + summe);

            op = Subtrahieren;
            summe = op(10, 15);
            Console.WriteLine("Differenz: " + summe);

            var alter = GetValue<int>("Bitte geben Sie Ihr Alter ein: ", ShowCustomErrorMessage);
        }

        private static int Addieren(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        private static int Subtrahieren(int zahl1, int zahl2)
        {
            return zahl1 - zahl2;
        }

        private static T GetValue<T>(string inputPrompt, Action<Exception> errorHandler) where T : IParsable<T>   //Constraints
        {
            bool inputIsValid = false;
            T userValue = default(T);
            Type type = typeof(T);

            do
            {
                Console.Write(inputPrompt);
                try
                {
                    var methode = type.GetMethod("Parse", new Type[] { typeof(string) });
                    if (methode != null)
                    {
                        userValue = (T)methode.Invoke(null, new object[] { Console.ReadLine() });
                        inputIsValid = true;
                    }
                }
                catch(Exception ex)
                {
                    if (errorHandler != null)
                    {
                        errorHandler(ex);
                    }

                    inputIsValid = false;
                }
            }
            while (!inputIsValid);

            return userValue;
        }

        private static void DefaultErrorHandler(Exception ex)
        {
            Console.WriteLine("ERROR: Ungültige Eingabe.");
        }

        private static void ShowCustomErrorMessage(Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
        }
    }
}
