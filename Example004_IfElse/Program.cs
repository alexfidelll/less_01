System.Console.WriteLine("Введите имя пользователья");
string userName = Console.ReadLine();

if(userName.ToLower() == "маша")
    System.Console.WriteLine("Привет, это же Маша))");

else
    System.Console.WriteLine($"Привет, {userName}!");
