using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
   
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public event EmployeeBase.GradeAddedDelegate GradeAdded;

        public string Name => "Adam";

        public string Surname => throw new NotImplementedException();

       

        public void AddGrade(float grade)
        {
            int valueInInt = (int)grade;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)

        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                switch (grade)
                {
                    case "6":
                        this.grades.Add(100);
                        break;
                                            
                    case "5":
                        this.grades.Add(80);
                        break;
                    case "4":
                        this.grades.Add(40);
                        break;
                    case "3":
                        this.grades.Add(20);
                        break;
                    case "2":
                        this.grades.Add(20);
                        break;
                    default:
                        this.grades.Add(0);
                        break;
                }
            }
        }
        
        //{
        //    switch (grade) 
        //    {
        //        case grade "6":
        //            this.gades.Add(100);
        //            break;
        //        // 5 => 80
        //        // 4 => 60
        //        // 3 => 40
        //        // -3 => 35
        //        // 3- => 35
        //        // 2+ => 25
        //        // +2 => 25
        //        // 2 => 20
        //        // 1 => 0
        //        /// + / 1
        //        /// plus i miunus pomniejsza lub powoieksza o 5
        //    }


        //}

        public Statistics GetStatistics()
        {
            return new Statistics();
        }
    }
}
