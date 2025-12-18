namespace ArraysGL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl;

            //Deklaration
            int[] zahlen;
            string[] namen;
            //Teilnehmer[] teilnehmerListe;

            //Dimensionierung
            //5 ist die Anzahl der Element in der Liste
            zahlen = new int[] { 0,0,0,0,0 };

            zahlen[0] = 2;
            zahlen[1] = 4;
            zahlen[2] = 2543;
            zahlen[3] = 1560;

            Console.WriteLine("Wert 1 = " +  zahlen[0]);
        }

    }
}
