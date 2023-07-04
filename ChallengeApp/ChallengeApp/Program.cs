
/*User user1 = new User("Ala", "11");
User user2 = new User("Ela", "22");
User user3 = new User("Ola", "33");
User user4 = new User("Wiola", "44");


var loginName1 = user1.Login;

user1.AddScore(5);
user1.AddScore(7);
var result = user1.Result;
Console.WriteLine(loginName1 + " \nSuma punktów to: " + result);*/


//zmienna statyczna
Console.WriteLine(User.GameName);
//np.obiekt typu Math ma w sobie zmienną statyczną PI(aby podglądnąć jak jest to zaimplementowane najechać na PI i pod prawym "Go to implementation" )
var pi = Math.PI;
Console.WriteLine(pi);



class User
{
    //zmienna statyczna, dostępna z szablonu obiektu User.GameNAme bez konieczności tworzenia obiektu z klasy
    public static string GameName = "Diablo";

    private List<int> score = new List<int>();

    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
        //GameName//można w środku wywołać ale bez this.
    }
    public string Login { get; private set; }
    public string Password { get; private set; }
   
    public int Result
    {
        get
        {
            return this.score.Sum();
            
        }
    }
    public void AddScore(int number)
    {
        this.score.Add(number);
    }
   
}












