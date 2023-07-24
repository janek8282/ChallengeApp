using ChallengeApp;

var employee1 = new Employee("Ola", "Kloc");

employee1.AddGrade("99");
employee1.AddGrade("AA");
employee1.AddGrade(88);
employee1.AddGrade(1235.5555m);



var statistics = employee1.GetStatistics();

Console.WriteLine($"Wartość min : {statistics.Min}");
Console.WriteLine($"Wartość max : {statistics.Max}");
Console.WriteLine($"Wartość avg : {statistics.Avg:N2}");


/*//-------------- 1 --------------------------------------------------------------------------
//przekazując do metody obiekt Statistics przekazujemy go na zasadzie wartości referencji 
//i nie jesteśmy w stanie nadpisać oryginalnego obiektu 
//nawet przypisując do statistics nowy obiekt Statistics

SetSth(statistics)

 void SetSth(Statistics statistics)
{
    statistics = new Statistics();
}*/


/*//-------------- 2 ref ----------------------------------------------------------------------
//przekazując do metody obiekt Statistics przekazujemy go na zasadzie wartości referencji 
//i nie jesteśmy w stanie nadpisać oryginalnego obiektu chyba że podamy "ref"
//przed przekazywanymi parametrami do metodi i przy jej wywołaniu


SetSth(ref statistics);

void SetSth(ref Statistics statistics)
{
    statistics = new Statistics();
}*/


/*//-------------- 3 out ----------------------------------------------------------------------
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