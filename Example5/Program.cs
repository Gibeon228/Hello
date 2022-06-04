Console.WriteLine("Введите имя ");
String username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Это Маша");
}
else 
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}
