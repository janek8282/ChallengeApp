using ChallengeApp;
using System.Diagnostics;
using System.Text.RegularExpressions;

Console.WriteLine("Witamy w programie do oceny Pracowników");
 Console.WriteLine("========================================");
Console.WriteLine();
Console.WriteLine("Wprowadź oceny z zakresu 0-100" +
    "\n lub litery które odpowiadają odpowiednio wartościom" +
    "\n A,a = 100" +
    "\n B,b = 80" +
    "\n C,c = 60" +
    "\n D,d = 40" +
    "\n E,e = 20");
Console.WriteLine("========================================");
Console.WriteLine();
Console.WriteLine("Podaj pierwszą ocenę pracownika: ");

var employee = new EmployeeInMemory("Ala", "Kloc");

while (true)
{
    var input = Console.ReadLine();
    if (input == "q") break;
    try
    {
        if (input.Length == 1 && Char.IsLetter(input[0]))
        {
            char inputToChar = (char)input[0];
            employee.AddGrade(inputToChar);
        }
        else
        {
            employee.AddGrade(input);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception: {e.Message}");
    }
    Console.WriteLine("Podaj kolejną ocenę pracownika lub wprowadź 'q' aby zakończyć wprowadzanie");
}
try
{
    var stat = employee.GetStatistics();
    Console.WriteLine($"Ocena pracownika : {stat.AvgLetter}");
    Console.WriteLine($"Wartość min : {stat.Min}");
    Console.WriteLine($"Wartość max : {stat.Max}");
    Console.WriteLine($"Wartość avg : {stat.Avg:N2}");
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e.Message}");
}
/*Console.WriteLine("Witamy w programie do oceny Przełożonych");
Console.WriteLine("========================================");
Console.WriteLine();
Console.WriteLine("Wprowadź punktację z zakresu 0-100" +
    "\n lub litery/oceny, które odpowiadają odpowiednio wartościom" +
    "\n A,a,6 = 100" +
    "\n B,b,5 = 80" +
    "\n C,c,4 = 60" +
    "\n D,d,3 = 40" +
    "\n E,e,2 = 20" +
    "\n 1 = 0" + 
    "\n każdy '+' podwyższa ocenę o 5 punktów a '-' obniża 0 5 punktów");
Console.WriteLine("========================================");
Console.WriteLine();
Console.WriteLine("Podaj pierwszą ocenę przełożonego: ");

var employee = new Supervisor("Ala", "Kloc");

while (true)
{
    var input = Console.ReadLine();
    if (input == "q") break;
    try
    {
        if (input.Length == 1 && Char.IsLetter(input[0]))
        {
            char inputToChar = (char)input[0];
            employee.AddGrade(inputToChar);
        }
        else
        {
            employee.AddGrade(input);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception: {e.Message}");
    }
    Console.WriteLine("Podaj kolejną ocenę przełożonego lub wprowadź 'q' aby zakończyć wprowadzanie");
}
try
{
    var stat = employee.GetStatistics();
    Console.WriteLine($"Ocena przełożonego : {stat.AvgLetter}");
    Console.WriteLine($"Wartość min : {stat.Min}");
    Console.WriteLine($"Wartość max : {stat.Max}");
    Console.WriteLine($"Wartość avg : {stat.Avg:N2}");
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e.Message}");
}*/

