namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void employeeSumOfScores()
        {
            //arrange
            var employee = new Employee("Ala", "Kloc", 28);
            employee.AddScore(4);
            employee.AddScore(7);
           
            //act
            int employeeScores = employee.SumOfScores;

            //assert
            Assert.AreEqual(11, employeeScores);
        }
    }
}