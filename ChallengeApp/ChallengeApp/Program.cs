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
    "\n C,c = 80" +
    "\n D,d = 80" +
    "\n E,e = 80");
Console.WriteLine("========================================");
Console.WriteLine();
Console.WriteLine("Podaj pierwszą ocenę pracownika: ");

var employee = new Employee();

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


