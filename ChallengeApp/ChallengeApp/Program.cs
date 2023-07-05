using ChallengeApp;

var employee1 = new Employee("Ala", "Kloc", 28);
var employee2 = new Employee("Ela", "Pałac", 35);
var employee3 = new Employee("Ola", "Miła", 41);

employee1.AddScore(4);  employee2.AddScore(9);  employee3.AddScore(5);
employee1.AddScore(7);  employee2.AddScore(6);  employee3.AddScore(5);
employee1.AddScore(3);  employee2.AddScore(1);  employee3.AddScore(9);
employee1.AddScore(9);  employee2.AddScore(3);  employee3.AddScore(3);
employee1.AddScore(7);  employee2.AddScore(8);  employee3.AddScore(4);

var employee1SumOfScores = employee1.SumOfScores;
var employee2SumOfScores = employee2.SumOfScores;
var employee3SumOfScores = employee3.SumOfScores;

int maxValueOfScores = employee1SumOfScores;
Employee employee;

if (maxValueOfScores < employee2SumOfScores)
{
    maxValueOfScores = employee2SumOfScores;
    employee = employee2;
}
else if (maxValueOfScores < employee3SumOfScores)
{
    maxValueOfScores = employee3SumOfScores;
    employee = employee3;
}
else
{
    employee = employee1;
}
Console.WriteLine("Njawiększą sumę punktów --> "
    + maxValueOfScores + " uzyskał pracownik:\n" 
    + employee.Name + " " + employee.SurName + "\n" 
    + employee.Age + " lat");