namespace ChallengeApp
{
    public class Employee
    {
        private List<int> scores = new List<int>();
        public object? surname;

        public Employee(string name, string surName, int age)
        {
            this.Name = name;
            this.SurName = surName;
            this.Age = age;
        }

        public Employee(string name, string surName)
        {
            this.Name = name;
            this.SurName = surName;
        }

        public string Name { get; private set; }
        public string SurName { get; private set; }
        public int Age { get; private set; }

        public int SumOfScores
        {
            get
            {
                return this.scores.Sum();
            }
        }
        public void AddScore(int score)
        {
            this.scores.Add(score);
        }
        public void SubtractScore(int score)
        {
            this.scores.Add(score * (-1));
        }
    }
}

