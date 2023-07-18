namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
//wprowadzam dane do testów
        string employeeName = "Ela";
        string employeeSurNamee = "Kowalska";
        int gradeMin = -3;
        int grade1 = -1;
        int grade2 = 5;
        int grade3 = 10;
        int gradeMax = 11;

 //metoda zwracaj¹ca obiekt klasy Employee       
        private Employee GetEmployeeNameSurname(string name, string surname)
        {
            return new Employee(name, surname);
        }

//sprawdzam imiê i nazwisko pracownika
        [Test]
        public void TestClassEmployee()
        {
            //arrange
            var employee1 = GetEmployeeNameSurname(employeeName, employeeSurNamee);

            //assert
            Assert.AreEqual(employeeName, employee1.Name);
            Assert.AreEqual(employeeSurNamee, employee1.SurName);
        }
//sprawdzam statystyki
        [Test]
        public void TestClassStatistics()
        {
            //arrange
            var employee1 = GetEmployeeNameSurname(employeeName, employeeSurNamee);
            employee1.AddGrade(gradeMin);
            employee1.AddGrade(grade1);
            employee1.AddGrade(grade2);
            employee1.AddGrade(grade3);
            employee1.AddGrade(gradeMax);

            //act
            var statistics = employee1.GetStatistics();
            var Avg = employee1.grades.Sum() / employee1.grades.Count();

            //assert
            Assert.AreEqual(gradeMin, statistics.Min);
            Assert.AreEqual(gradeMax, statistics.Max);
            Assert.AreEqual(Avg, statistics.Avg);
        }
    }
}