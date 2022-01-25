using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicClassLibrary
{
    public class Person
    {
        public string Sex { get; set; }
        public string Status { get; set; } = "alive";
        public int DateOfBirth { get; set; }
        public int DateOfDecease { get; set; } = -1;

        public static Dictionary<int[], double> DeathRuleMales { get; set; }
        public static Dictionary<int[], double> DeathRuleFemales { get; set; }

        //public delegate void DeceaseHandler<T>(object sender, T e);
        public event EventHandler<DeceaseArgs> PersonIsDeceased;
       

        //public delegate void BirthHandler<T>(object sender, T e);
        public event EventHandler<BirthArgs> PersonIsBorn;

        public Person(string sex, int dateOfBirth, Dictionary<int[], double> deathRuleFemales, Dictionary<int[], double> deathRuleMales)
        {
            Sex = sex;
            DateOfBirth = dateOfBirth;
            DeathRuleFemales = deathRuleFemales;
            DeathRuleMales = deathRuleMales;
        }

       public void OnYearTicked(object sender, YearTickArgs e)
        {
            double DeceaseProb;
            if (Status == "alive")
            {
                if (Sex == "male")
                { 
                    DeceaseProb = DeathRuleMales.First(R => R.Key.Any(A => A == e.CurrentYear - DateOfBirth)).Value;
                    if (ProbabilityCalculator.IsEventHappened(DeceaseProb))
                    {
                        PersonIsDeceased?.Invoke(this, new DeceaseArgs(e.CurrentYear));
                    }
                }
                else
                {
                    DeceaseProb = DeathRuleFemales.First(R => R.Key.Any(A => A == e.CurrentYear - DateOfBirth)).Value;
                    if (ProbabilityCalculator.IsEventHappened(DeceaseProb))
                    {
                        PersonIsDeceased?.Invoke(this, new DeceaseArgs(e.CurrentYear));
                    }
                }
            }

            if (Sex == "female" && Status=="alive" && e.CurrentYear-DateOfBirth>=18 && e.CurrentYear - DateOfBirth<=45)
            {
                if (ProbabilityCalculator.IsEventHappened(0.151))
                {                   
                    PersonIsBorn?.Invoke(this, new BirthArgs(e.CurrentYear));
                }
            }
        }

    }




}
