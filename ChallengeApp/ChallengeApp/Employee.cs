namespace ChallengeApp
{
    public class Employee
    {
        private List<int> scores = new List<int>();

        public Employee(string name, string surName, int age)
        {
            this.Name = name;
            this.SurName = surName;
            this.Age = age;
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
            //this.scores.Add(-1);
        }
    }
}

