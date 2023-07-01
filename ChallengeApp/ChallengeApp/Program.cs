int number = 1631154407;
string numberInString = number.ToString();


Console.WriteLine("Wyniki dla liczby: " + numberInString);

for (int i = 0; i < 10; i++)
{
    int countDigit = 0;

    foreach (var str in numberInString)
    {
        if (str == (char)(i + '0'))
        {
          countDigit++;
        }
    }
    Console.WriteLine(i + " => " + countDigit);
}











