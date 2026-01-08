namespace KlassenGrundlagen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanziierung
            Employee ma = new Employee("Max", "Muster", new DateTime(2006, 2, 15));

            ////Initialisierung
            //ma.Name = "Max";
            //ma.Surname = "Muster";
            //ma.Id = Guid.NewGuid();
            //ma.Sallery = 1700.0m;
            //ma.Birthday = new DateTime(2006, 2, 15);
            
            ma.GiveBonus(0.1);
            ma.Display();

            //bonus geben
            ma.GiveBonus(0.1);

            //neues Gehalt darstellen:
            Console.WriteLine($"Neues Gehalt: EUR {ma.Sallery.ToString("#,###.00")}");
        }
    }
}
