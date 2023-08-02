namespace ChallengeApp
{
    public class Person //każda klasa dziedziczy po klasie :System.Object
    {
        protected int counter;//zmienna typu protected chroni przed odczytem z zewnątrz,
                              //ale udostęopnia do klasy Employee(można ją odczytać w konstruktorze Employee)
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
    }
}