namespace ChallengeApp
{
    public abstract class Person //każda klasa dziedziczy po klasie :System.Object
    {
        public Person() :this("no name", "no surname") { }
        public Person(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
        }
        public Person(string name, string surname, int age)
        {
            this.Name = name;
            this.SurName = surname;
            this.Age = age;
        }
        public Person(string name, string surname, int age, char sex)
        {
            this.Name = name;
            this.SurName = surname;
            this.Age = age;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set; }
    }
}