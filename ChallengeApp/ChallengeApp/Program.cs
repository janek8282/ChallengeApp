
User user1 = new User("Ala", "11");
User user2 = new User("Ela", "22");
User user3 = new User("Ola", "33");
User user4 = new User("Wiola", "44");


var loginName1 = user1.Login;

user1.AddScore(5);
user1.AddScore(7);

var result = user1.Result;
Console.WriteLine(loginName1 + " \nSuma punktów to: " + result);


class User
{
    //przechowuje Liste z punktami, lista nie dostępna na zewnątrz ale wynik widoczny
    private List<int> score = new List<int>();

    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }
    //modyfikatory dostępu
    public string Login { get; private set; }
    public string Password { get; private set; }
   
    public int Result
    {
        get
        {
            return this.score.Sum();
            
        }
    }

    //metoda z void --> nic nie zwraca
    public void AddScore(int number)
    {
        this.score.Add(number);
    }
}












