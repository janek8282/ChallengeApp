namespace ChallengeApp
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }//ustawienie name jest możliwe tylko w klasie Person
    }
}