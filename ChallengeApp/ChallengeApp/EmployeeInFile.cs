namespace ChallengeApp
{
    public abstract class EmployeeInFile : EmployeeBase
    {
        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {

        }

        public override void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(long grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
