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
        //----------------------------------------------------
        public void AddGrade(float grade)
        {
                this.grades.Add(grade);
        }
        //metoda GetStatistics w klasie Employee utworzona na podstawie modelu danych czyli klasy Statistics
        public Statistics GetStatistics()
        {
            var statistics= new Statistics();

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


 