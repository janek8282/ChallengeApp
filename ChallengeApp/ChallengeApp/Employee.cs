using ChallengeApp;
using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee : Person
    {
        public List<float> grades = new List<float>();

        public Employee()//bez parametru
           : this("no name")//przekazuje do konstruktora z jednym parametrem
        {
            this.SurName = surname;// nie ma sensu 
        }
        public Employee(string name)
           : this(name, "no surname")//przekazuje do konstruktora z dwoama parametrami
        {
            this.SurName = surname;// nie ma sensu
        }
        public Employee(string name, string surname)
            : base(name)//przekazuje do klasy Person
        {
            this.SurName = surname;
        }

        public string SurName { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade -> out of range");
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
                throw new Exception("String is not a float");
            }
        }

        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(decimal grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter!");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Avg = 0;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avg += grade;
            }
            statistics.Avg /= this.grades.Count;

            switch (statistics.Avg)
            {
                case var temp when temp >= 80:
                    statistics.AvgLetter = 'A';
                    break;
                case var temp when temp >= 60:
                    statistics.AvgLetter = 'B';
                    break;
                case var temp when temp >= 40:
                    statistics.AvgLetter = 'C';
                    break;
                case var temp when temp >= 20:
                    statistics.AvgLetter = 'D';
                    break;
                default:
                    throw new Exception($"Average below the lower limit : < 20" +
                        $" \nOcena pracownika : 'N'" +
                        $"\nWartość min : {statistics.Min}" +
                        $"\nWartość max : {statistics.Max}" +
                        $"\nWartość avg : {statistics.Avg}");
            }
            return statistics;
        }
    }
}