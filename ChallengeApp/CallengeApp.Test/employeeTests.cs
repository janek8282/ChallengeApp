namespace ChallengeApp.Tests
{
    public class employeeTests
    {
        [Test]
        public void employeeSumOfScores_OnlyPositives()
        {
            //arrange
            var employee = new Employee("Ala", "Kloc", 28);
            employee.AddScore(4);
            employee.AddScore(7);

            //act
            int employeeSumOfScore = employee.SumOfScores;

            //assert
            Assert.AreEqual(11, employeeSumOfScore);
        }

        [Test]
        public void employeeSumOfScores_OnlyNegatives()
        {
            //arrange
            var employee = new Employee("Ala", "Kloc", 28);
            employee.SubtractScore(4);
            employee.SubtractScore(7);

            //act
            int employeeSumOfScore = employee.SumOfScores;

            //assert
            Assert.AreEqual(-11, employeeSumOfScore);
        }
        [Test]
        public void employeeSumOfScores_All()
        {
            //arrange
            var employee = new Employee("Ala", "Kloc", 28);
            employee.AddScore(4);
            employee.SubtractScore(7);

            //act
            int employeeSumOfScore = employee.SumOfScores;

            //assert
            Assert.That(-3, Is.EqualTo(employeeSumOfScore));
        }

    }
}