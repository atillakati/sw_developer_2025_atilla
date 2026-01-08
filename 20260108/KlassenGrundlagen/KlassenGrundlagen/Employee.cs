
namespace KlassenGrundlagen
{
    public class Employee
    {
        //Zustandsinformationen
        public string Name;
        public string Surname;
        public Guid Id;
        public decimal Sallery;
        public DateTime Birthday;

        //std. Konstruktor
        //public Employee()
        //{
        //    Name = "No";
        //    Surname = "Name";
            
        //    Id = Guid.NewGuid();
        //    Sallery = 1000.0m;
        //}       

        //user spezific contructor
        public Employee(string name, string surname, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;

            Id = Guid.NewGuid();
            Sallery = 1000.0m;
        }

        public void GiveBonus(double bonusInPercent)
        {
            if (bonusInPercent > 0 && bonusInPercent <= 1)
            {
                //new sallery with bonus
                Sallery += Sallery * (decimal)bonusInPercent;

                int age = DateTime.Now.Year - Birthday.Year;

                //20 => 2000   25 ==> 2500   //40 => 4000
                decimal maxSallery = age * 100;
                if(Sallery > maxSallery)
                {
                    Sallery = maxSallery;
                }
            }            
        }

        //Methoden/Logik
        public void Display()
        {
            Console.WriteLine($"{Name} {Surname}");
            Console.WriteLine($"ID: {Id}");
        }


    }
}
