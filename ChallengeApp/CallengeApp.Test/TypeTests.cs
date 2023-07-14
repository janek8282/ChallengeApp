namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void testInt()
        {
            //arrange
            int num1 = 2;
            int num2 = 2;
            //assert
            Assert.AreEqual(num1, num2);
        }
        [Test]
        public void testFloat()
        {
            //arrange
            float num1 = 2.234f;
            float num2 = 2.456f;
            //assert
            Assert.AreNotEqual(num1, num2);
        }
        [Test]
        public void testString()
        {
            //arrange
            string str1 = "Ala";
            string str2 = "Ela";
            //assert
            Assert.AreNotEqual(str1, str2);
        }
        [Test]
        public void classObject()
        {
            //arrange
            var employee1 = GetEmployeeNameSurname("Ala", "Kowal");
            var employee2 = GetEmployeeNameSurname("Ela", "Kowal");
            //assert
            Assert.AreEqual(employee1.surname, employee2.surname);

        }
        private Employee GetEmployeeNameSurname(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}
