namespace EsercitazioneCreazioneClassi
{


    public class Athlete
    {
        public int Age;
        public string Sport;
        public string Name;

        public void Run()
        {
            Console.WriteLine("Run");
        }
        public int AddYears(int Year)
        {
            return Age + Year;
        }

    }


    public class Dipendente
    {
        public string Name;
        public bool isEmployed;
        public string Company;
        public int WeeklyWorkHours;
        public float PaySlip;

        public void Work()
        {
            Console.WriteLine("Work");
        }
        public bool HasFoundWork(bool state)
        {
            return isEmployed = state;
        }
        public string ChangeJob(string NewCompany)
        {
            return Company = NewCompany;
        }
    }

    
    public class Animale
    {
        public string Breed;
        public string Name;
        public int Age;

        public void Bark()
        {
            Console.WriteLine("Wof");
        }
        public void Sit()
        {
            Console.WriteLine("I am sitting");
        }

    }

    public class Veicolo
    {
        private int _year;

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
        private string Brand;
        public int Cilindrata;

        // Getters and setters
        public string getBrand()
        {
            return Brand;
        }
        public void setBrand(string inputValue)
        {
            Brand = inputValue;
        }
        public void Accelera()
        {
            Console.WriteLine("Bruh");
        }

    }


    class MainClass
    {
        static void Main(string[] args)
        {
            Veicolo Maserati = new Veicolo();

            Maserati.Cilindrata = 500;
            Maserati.setBrand("Maserati");
            Console.WriteLine(Maserati.getBrand());
            Console.WriteLine("La cilindrata è: " + Maserati.Cilindrata.ToString() + "cc");
            Maserati.Accelera();
            Maserati.Year = 1957;
            Console.WriteLine($"Il mio anno di fabbricazione è {Maserati.Year}");

            Animale Cane = new Animale();
            Cane.Name = "Pippo";
            Cane.Breed = "Labrador";
            Cane.Age = 12;
            Console.WriteLine($"Ciao sono un cane. Il mio nome è {Cane.Name}, sono un {Cane.Breed} di {Cane.Age} anni.");
            Console.WriteLine($"Quando mi arrabbio, abbaio e faccio");
            Cane.Bark();

        }

    }
}


