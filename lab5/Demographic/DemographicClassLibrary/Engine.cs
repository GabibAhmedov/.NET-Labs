using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;


namespace DemographicClassLibrary
{
    public class Engine:IEngine
    {
        private List<Person> _people = new List<Person>();
        private int _startYear;
        private int _finalYear;
        private int _population;
        public const int scale=1000;

        private Dictionary<int, double> _initAge;
        public static Dictionary<int[], double> DeathRuleMales { get; set; }
        public static Dictionary<int[], double> DeathRuleFemales { get; set; }


        //public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);
        public delegate void YearTickHandler<T>(object sender, T e);
        //public delegate void YearTickHandler<T>(object sender,Chart chart, T e);      
        public event YearTickHandler<YearTickArgs> YearTicked;
        

        public List<Person> GetPeople
        {
            get { return _people; }
        }
        public int GetFinalYear
        {
            get { return _finalYear; }
        }
        public int GetStartYear
        {
            get { return _startYear; }
        }
        public int GetPopulation
        {
            get { return _population; }
        }

        public Engine(
            Dictionary<int, double> initAge, 
            Dictionary<int[], double> deathRuleMales,
            Dictionary<int[], double> deathRuleFemales,
            int startYear, 
            int finalYear, 
            int population
            )
        {
            _startYear = startYear;
            _finalYear = finalYear;
            _population = population*scale;
            _initAge = initAge;
            DeathRuleMales = deathRuleMales;
            DeathRuleFemales = deathRuleFemales;
        }

        public  void InitiateModel()
        {
            int pACount = 0;
            int pTCount = 0;
            foreach (KeyValuePair<int, double> keyValue in _initAge)
            {
                pACount = 0;
                do
                {
                    Person person = new Person("male", _startYear - keyValue.Key, DeathRuleFemales, DeathRuleMales);
                    YearTicked += person.OnYearTicked;
                    person.PersonIsBorn += OnPersonBorn;
                    person.PersonIsDeceased += OnPersonDeceased;
                    _people.Add(person);                   
                    pACount++;
                    pTCount++;                   
                } while (pACount < (Math.Round(keyValue.Value) * _population / scale /2) && (pTCount < (_population / 2)));
            }
            pTCount = 0;
            foreach (KeyValuePair<int, double> keyValue in _initAge)
            {
                pACount = 0;
                do
                {
                   Person person = new Person("female", _startYear - keyValue.Key, DeathRuleFemales, DeathRuleMales);
                   YearTicked += person.OnYearTicked;
                   person.PersonIsBorn += OnPersonBorn;
                   person.PersonIsDeceased += OnPersonDeceased;
                   _people.Add(person);
                   pACount++;
                   pTCount++;                  
                } while (pACount < (Math.Round(keyValue.Value) * _population / scale /2) && (pTCount < (_population/2)));
            }
            _population = _people.Count;

        }

        public void StartModel()
        {

            for(int i= _startYear; i<=_finalYear;i++)
            {
                YearTicked?.Invoke(this, new YearTickArgs(i,_population));               
            }
        }

        public void OnPersonBorn(object sender, BirthArgs e )
        {
            if (ProbabilityCalculator.IsEventHappened(0.55))
            {
                var person = new Person("female", e.CurrentYear, DeathRuleFemales, DeathRuleMales);
                YearTicked += person.OnYearTicked;
                person.PersonIsBorn += OnPersonBorn;
                person.PersonIsDeceased += OnPersonDeceased;
                _people.Add(person);               
                _population++;
            }
            else 
            {
                var person = new Person("male", e.CurrentYear, DeathRuleFemales, DeathRuleMales);
                YearTicked += person.OnYearTicked;
                person.PersonIsBorn += OnPersonBorn;
                person.PersonIsDeceased += OnPersonDeceased;
                _people.Add(person);
                _population++;
            }
        }

        public void OnPersonDeceased(Object sender, DeceaseArgs e)
        {
            Person DeceasedPerson = (Person)sender;            
            DeceasedPerson.DateOfDecease = e.CurrentYear;
            YearTicked -= DeceasedPerson.OnYearTicked;
            DeceasedPerson.Status = "deceased";
            _population--;
        }
    }
}

