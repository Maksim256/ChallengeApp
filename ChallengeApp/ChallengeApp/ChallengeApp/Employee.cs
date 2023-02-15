using Microsoft.VisualBasic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp
    
{
    public class Employee
    {
        private List<int> scoreA = new List<int>();

        public Employee(string imie, string nazwisko, int wiek)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
        }

        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public int Wiek { get; private set; }
        
        public int Wynik
        {
            get
            {
                return this.scoreA.Sum();
            }
        }

        public int Maksimum
        {
            get
            {
                return this.scoreA.Max();
            }
        }

        public void AddScore(int numberA)
        {
            this.scoreA.Add(numberA);
          //  this.scoreA.Add(-1);
        }
        
        public void SubstractScore(int numberA)
        {
            this.scoreA.Add(- numberA  );
           
        }
    }
}
