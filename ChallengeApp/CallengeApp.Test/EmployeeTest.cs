namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
 //wprowadzam dane do testów
        string employeeName = "Ela";
        string employeeSurNamee = "Kowalska";
        int gradeMin = 3;
        int grade1 = 11;
        char grade2 = 'c';
        char grade3 = 'B';
        int gradeMax = 89;
        char rating;
 //metoda zwracająca obiekt klasy Employee       
        private Employee GetEmployeeNameSurname(string name, string surname)
        {
            return new Employee(name, surname);
        }
 //---1---sprawdzam imię i nazwisko pracownika
        [Test]
        public void TestClassEmployee()
        {
            //arrange
            var employee1 = GetEmployeeNameSurname(employeeName, employeeSurNamee);

            //assert
            Assert.AreEqual(employeeName, employee1.Name);
            Assert.AreEqual(employeeSurNamee, employee1.SurName);
        }
 //---2---sprawdzam statystyki
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
            switch (Avg)
            {
                case >= 80:
                    rating = 'A';
                    break;
                case >= 60:
                    rating = 'B';
                    break;
                case >= 40:
                    rating = 'C';
                    break;
                case  >= 20:
                    rating = 'D';
                    break;
                default:
                    rating = 'N';
                    break;
            }
            //assert
            Assert.AreEqual(gradeMin, statistics.Min);
            Assert.AreEqual(gradeMax, statistics.Max);
            Assert.AreEqual(Avg, statistics.Avg);
            Assert.AreEqual(rating, statistics.AvgLetter);
        }
    }
}