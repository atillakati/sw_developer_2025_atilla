namespace GrundlagenKlassen_II
{
    public class Employee
    {
        //Zustandsinformationen
        private string _name;   // => private fields
        private string _surname;
        private Guid _id;
        private decimal _sallery;
        private DateTime _birthday;
        private AdresseExtendet _adress;

        //std. Konstruktor
        //public Employee()
        //{
        //    Name = "No";
        //    Surname = "Name";

        //    Id = Guid.NewGuid();
        //    Sallery = 1000.0m;
        //}       

        //user spezific contructor

        public Employee(string name, string surname, DateTime birthday, Adresse adress)
            : this(name, surname, birthday)
        {
            _adress = adress;
        }

        public Employee(string name, string surname, DateTime birthday)
        {
            _name = name;
            _surname = surname;
            _birthday = birthday;

            _id = Guid.NewGuid();
            _sallery = 1000.0m;            
        }


        public void GiveBonus(double bonusInPercent)
        {
            if (bonusInPercent > 0 && bonusInPercent <= 1)
            {
                //new sallery with bonus
                _sallery += _sallery * (decimal)bonusInPercent;

                int age = DateTime.Now.Year - _birthday.Year;

                //20 => 2000   25 ==> 2500   //40 => 4000
                decimal maxSallery = age * 100;
                if(_sallery > maxSallery)
                {
                    _sallery = maxSallery;
                }
            }            
        }

        //Methoden/Logik
        public void Display()
        {
            Console.WriteLine($"{_name} {_surname}");
            Console.WriteLine($"ID: {_id}");
        }


        //Änderungs- & Zugriffsmethoden
        //public decimal get_Sallery()
        //{
        //    return Sallery;
        //}

        //public void SetSurname(string newSurname)
        //{
        //    if (!string.IsNullOrEmpty(newSurname))
        //    {
        //        Surname = newSurname;
        //    }
        //}

        //Eigenschaften / Properties
        public string Name
        {
            get
            {
                return _name;
            }

            //set
            //{
            //    if (!string.IsNullOrEmpty(value))
            //    {
            //        _name = value;
            //    }
            //}
        }

        public string Surname
        {
            get { return _surname; }            
        }

        public Guid Id 
        {
            get { return _id; }
        }
        
        public DateTime Birthday
        {
            get { return _birthday; }
        }
        
        public decimal Sallery
        {
            get { return _sallery; }
        }
    

        public string Wohnort
        {
            get { return _adress.GetOrtFromGeoLocation(); }
            set
            {
                _adress.Wohnort = value;
            }
        }

        public int Plz
        {
            get { return _adress.Plz; }
        }

        //public Adresse Adress
        //{
        //    get { return _adress; }
        //}

    }
}
