using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using ChallengeApp;

namespace ChallengeApp
{
    public class Employee
    {
        // public string imie;
        //public string nazwisko;
        //public int wiek;
        //public int punkty;
        private List<int> scoreA = new List<int>();
        // List<Employee> employees = new List<Employee>()
        //{
            
        //};

        public Employee(string imie, string nazwisko, int wiek)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
            //this.Punkty = punkty;
        }

        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public int Wiek { get; private set; }
       public int Wynik
        { 
            get
            {
                return this.scoreA.Sum();
                //return this.employees.Sum();
            }
        }
        public int Maksimum
        {
            get
            {
                return this.scoreA.Max();
            }

        }
        //public int SortA
        //{
        //    get 
        //    {
        //        return this.scoreA.Sort();
        //    }
        //}

        

        public void AddPunty(int numberA)
        {
            this.scoreA.Add(numberA);
        }
    }
}
