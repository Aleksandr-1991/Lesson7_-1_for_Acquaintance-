Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "лена") // запомнить!
{
    Console.WriteLine("Ураа! Неужели это рыжик?)))");
}
else
{
    Console.Write("Привет, " + username); 
}