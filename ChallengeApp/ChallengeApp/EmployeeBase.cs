namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
        }
        public string Name { get; private set; }
        public string SurName { get; private set; }
        //dodając "abstract" do metody nie trzeba jej definiować w tej klasie,
        //można to zrobić w kolejnej klasie
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(long grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(char grade);
        public abstract void AddGrade(string grade);
        public abstract Statistics GetStatistics();

        //medtoda "virtual" musi byc zaimplementowana w klasie bazowej ale może byc równiez nadpisana w kolejnej klasie (głownej)
        public virtual void SayHello()
        {
            Console.WriteLine($"Siemka jestem {Name} {SurName}");
        }
    }
}
