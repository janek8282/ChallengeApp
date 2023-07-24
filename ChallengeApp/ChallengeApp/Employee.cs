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
                Console.WriteLine("Invalid grade");
            }
        }
        //--zamiana stringa na float ale bez walidacji-------
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);//wywołuje metodę AddGrade(float grade)
            }
            else
            {
                Console.WriteLine("String is not a float");
            }
        }
        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);//wywołuje metodę AddGrade(float grade)
        }
        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);//wywołuje metodę AddGrade(float grade)
        }
        public void AddGrade(decimal grade)
        {
            float result = (float)grade;
            this.AddGrade(result);//wywołuje metodę AddGrade(float grade)
        }


        //------------------------1-ForEach--------------------------------
        public Statistics GetStatisticsWithForEach()
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

            return statistics;
        }
        //------------------------2-For------------------------------------
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Avg = 0;

            for (var i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Avg += this.grades[i];
            }
            statistics.Avg /= this.grades.Count;

            return statistics;
        }
        //------------------------3-DoWhile--------------------------------
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Avg = 0;

            var i = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Avg += this.grades[i];
                i++;
            }
            while (i < this.grades.Count);

            statistics.Avg /= this.grades.Count;

            return statistics;
        }
        //------------------------4-While----------------------------------
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Avg = 0;

            var i = 0;
            while (i < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Avg += this.grades[i];
                i++;
            }
            statistics.Avg /= this.grades.Count;

            return statistics;
        }
    }
}