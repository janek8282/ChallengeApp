using ChallengeApp;

var employee1 = new Employee("Ola", "Kloc");

employee1.AddGrade("25");
employee1.AddGrade("AA");
employee1.AddGrade(15);
employee1.AddGrade(1235.5555m);

var statistics1 = employee1.GetStatisticsWithForEach();
var statistics2 = employee1.GetStatisticsWithFor();
var statistics3 = employee1.GetStatisticsWithDoWhile();
var statistics4 = employee1.GetStatisticsWithWhile();

Console.WriteLine("------------------------1-ForEach--------------------");
Console.WriteLine($"Wartość min : {statistics1.Min}");
Console.WriteLine($"Wartość max : {statistics1.Max}");
Console.WriteLine($"Wartość avg : {statistics1.Avg:N2}");
Console.WriteLine("------------------------2-For------------------------");
Console.WriteLine($"Wartość min : {statistics2.Min}");
Console.WriteLine($"Wartość max : {statistics2.Max}");
Console.WriteLine($"Wartość avg : {statistics2.Avg:N2}");
Console.WriteLine("------------------------3-DoWhile--------------------");
Console.WriteLine($"Wartość min : {statistics3.Min}");
Console.WriteLine($"Wartość max : {statistics3.Max}");
Console.WriteLine($"Wartość avg : {statistics3.Avg:N2}");
Console.WriteLine("------------------------4-While----------------------");
Console.WriteLine($"Wartość min : {statistics4.Min}");
Console.WriteLine($"Wartość max : {statistics4.Max}");
Console.WriteLine($"Wartość avg : {statistics4.Avg:N2}");













/*//-------------- 1 --------------------------------------------------------------------------
//przekazując do metody obiekt Statistics przekazujemy go na zasadzie wartości referencji 
//i nie jesteśmy w stanie nadpisać oryginalnego obiektu 
//nawet przypisując do statistics nowy obiekt Statistics

SetSth(statistics)

 void SetSth(Statistics statistics)
{
    statistics = new Statistics();
}


//-------------- 2 ref ----------------------------------------------------------------------
//przekazując do metody obiekt Statistics przekazujemy go na zasadzie wartości referencji 
//i nie jesteśmy w stanie nadpisać oryginalnego obiektu chyba że podamy "ref"
//przed przekazywanymi parametrami do metodi i przy jej wywołaniu


SetSth(ref statistics);

void SetSth(ref Statistics statistics)
{
    statistics = new Statistics();
}


//-------------- 3 out ----------------------------------------------------------------------
//przekazując do metody obiekt Statistics przekazujemy go na zasadzie wartości referencji 
//i nie jesteśmy w stanie nadpisać oryginalnego obiektu chyba że podamy "out"
//przed przekazywanymi parametrami do metodi i przy jej wywołaniu
//różnica między ref i out jest taka że przy ref możemy ale nie musimy nadpisywać obiektu w pamięci programu a przy out koniecznie - inaczej błąd
//dzieje się tak że przekazany parametr do funkcji nie ma przypisanej wartości a przy ref ma


SetSth(out statistics);

void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}*/