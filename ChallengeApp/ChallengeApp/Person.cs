namespace ChallengeApp
{
    public class Person //każda klasa dziedziczy po klasie :System.Object
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
    }
}