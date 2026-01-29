namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //delegates
            Action<string> action = DoSomething;
            action("Dies ist ein delegate-Aufruf");

            //anonyme Methode
            action = delegate (string message)
            {
                Console.WriteLine("Anonyme Methode: " + message);
            };
            action("Jetzt ganz anonym!");

            //Lambda Expressions
            action = (string message) =>
            {
                Console.WriteLine("Lambda: " + message.ToUpper());
            };
            action("Hier Lambada!");

            //Lambda Expressions
            action = m => Console.WriteLine("Kurz: " + m);
            action("Sehr kurze Variante!");

            //Anwendungsbeispiel: Zahlenfilter
            var meinZahlen = new[] { 1, 3, 5, 9, 13, 20, 22, 23, 30, 39, 40, 45, 48, 49 };

            var erg = Filter(meinZahlen, GeradeZahlenFilter);

            erg = Filter(meinZahlen, x => x < 10);
            erg = Filter(meinZahlen, x => x < 22);
            erg = Filter(meinZahlen, x => x % 2 != 0);
            erg = Filter(meinZahlen, x => x > 10 && x < 20);
            erg = Filter(meinZahlen, x => x != 5);

            //LINQ
            var result = meinZahlen
                                .Where(x => x > 5)
                                .Select(x => x.ToString())
                                .ToList();
        }

        private static bool GeradeZahlenFilter(int arg)
        {
            if(arg % 2 == 0)
            {
                return true;
            }

            return false;
        }

        private static int[] Filter(IEnumerable<int> zahlen, Predicate<int> filterCriteria)
        {
            var filteredValues = new List<int>();

            foreach (var zahl in zahlen)
            {
                if (filterCriteria(zahl))
                {
                    filteredValues.Add(zahl);
                }
            }

            return filteredValues.ToArray();
        }

        private static void DoSomething(string message)
        {
            Console.WriteLine(message);
        }
    }
}
