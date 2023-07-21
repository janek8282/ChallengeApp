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

        //metoda GetStatistics w klasie Employee utworzona na podstawie modelu danych czyli klasy Statistics
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

            return statistics;
        }
    }
}


