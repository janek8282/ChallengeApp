namespace ChallengeApp
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public Person()
        {
            this.Name = "no name";
        }
        public string Name { get; set; }
    }
}