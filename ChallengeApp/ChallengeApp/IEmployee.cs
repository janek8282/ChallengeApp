namespace ChallengeApp
{
    public interface IEmployee
    {
        public string Name { get; }
        public string SurName { get; }

        void AddGrade(float grade);
        void AddGrade(long grade);
        void AddGrade(double grade);
        void AddGrade(char grade);
        void AddGrade(string grade);

        Statistics GetStatistics();
    }
}
