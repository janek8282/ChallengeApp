using ChallengeApp;

var employee1 = new Employee("Ala", "Kloc", 28);
var employee2 = new Employee("Ela", "Pałac", 35);
var employee3 = new Employee("Ola", "Miła", 41);

employee1.AddScore(4);  employee2.AddScore(9);  employee3.AddScore(5);
employee1.AddScore(7);  employee2.AddScore(6);  employee3.AddScore(5);
employee1.AddScore(3);  employee2.AddScore(5);  employee3.AddScore(9);
employee1.AddScore(9);  employee2.AddScore(3);  employee3.AddScore(3);
employee1.AddScore(1);  employee2.AddScore(1);  employee3.AddScore(4);


List<Employee> listOfEmployees = new List<Employee>()
{
employee1, employee2, employee3
};

int maxValueOfScores = 0;
Employee employee = null;

foreach (var singleEmployee in listOfEmployees)
{
    if(singleEmployee.SumOfScores > maxValueOfScores)
    {
        maxValueOfScores = singleEmployee.SumOfScores;
        employee = singleEmployee;
    }
}



Console.WriteLine("Njawiększą sumę punktów --> "
    + maxValueOfScores + " uzyskał pracownik:\n" 
    + employee.Name + " " + employee.SurName + "\n" 
    + employee.Age + " lat");