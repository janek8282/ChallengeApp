using ChallengeApp;//korzystamy z przestrzeni naz i mamy dostęp do klasy USer, która jest tam zawarta
//każdą klasę należy umieszczać w osobnym pliku klasy
User user1 = new User("Ala", "11");
User user2 = new User("Ela", "22");
User user3 = new User("Ola", "33");
User user4 = new User("Wiola", "44");


var loginName1 = user1.Login;

user1.AddScore(5);
user1.AddScore(7);
var result = user1.Result;
Console.WriteLine(loginName1 + " \nSuma punktów to: " + result);





