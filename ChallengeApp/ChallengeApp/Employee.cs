using ChallengeApp;
using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        public List<float> grades = new List<float>();

        //----------------------------------------------------
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
        }
        public Employee() { }
        
        //----------------------------------------------------
        public string Name { get; private set; }
        public string SurName { get; private set; }

        //--walidacja danyh przy wprowadzaniu wartości float--
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade - out of range(poza zakresem)");
                //Console.WriteLine("Invalid grade - out of range(poza zakresem)");
            }
        }
        //--zamiana stringa na float ale bez walidacji-------
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not a float");
                //Console.WriteLine("String is not a float");
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
        //switch
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
                    //nie potrzeba break bo po throw wyskakuje z metody
                    //Console.WriteLine("Wrong letter!");
                    
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
                    Console.WriteLine("Średnia poniżej dolnej granicy: < 20");
                    statistics.AvgLetter = 'N';
                    break;
            }
            return statistics;
        }
    }
}