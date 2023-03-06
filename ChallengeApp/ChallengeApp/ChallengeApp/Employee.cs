using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            int valueInInt = (int)grade;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {

            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            //ta petla zawsze wykona sie choć raz
        //    var index = 0;
            //do
            //{
            //    statistics.Max = Math.Max(statistics.Max, this.grades[index]);
            //    statistics.Min = Math.Min(statistics.Min, this.grades[index]);
            //    statistics.Average += this.grades[index];
            //    index++;
            //} while (index < this.grades.Count);

            //while (index < this.grades.Count)
            //{
            //    if (this.grades[index] == 5)
            //    {
            //        break;
            //    }
            //    statistics.Max = Math.Max(statistics.Max, this.grades[index]);
            //    statistics.Min = Math.Min(statistics.Min, this.grades[index]);
            //    statistics.Average += this.grades[index];
            //    index++;
            //}

            foreach (var grade in this.grades)
            {
                //w tym przypadku jeżeli grade będzie mniejsz od zera
                //to wykonuje nastęny przebie pętli
                //pomijąc ten przebieg.

                //goto
                if (grade == 11)
                {
                    //  continue;
                    //    goto here;
                }


                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            // here:

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }


        public Statistics GetStatisticsWithForEach()
        {

            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average =statistics.Average / this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Average += grades[i];
            }
            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;

        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
                index++;
            }
            while (index < this.grades.Count);
            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            while (index < this.grades.Count)
            {
                if (this.grades[index] == 4)
                {
                    break;
                }

                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += this.grades[index];
                index++;
            }

                statistics.Average = statistics.Average / this.grades.Count;
                return statistics;
            
        }
    }

}

