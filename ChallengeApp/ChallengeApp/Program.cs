var name = "Ewa";
var genderWoman = true;
var age = 31;

if (genderWoman == true)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        Console.WriteLine("Kobieta w wieku 30+ lat");
    }
}
else
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Męszczyzna");
    }
    else
    {
        Console.WriteLine("Pełnoletni Męszczyzna");
    }
}



















