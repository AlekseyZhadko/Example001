// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if(username.ToLower == "masha")
{
    Console.Write("Good, hello Masha");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}