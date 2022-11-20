/*
Console.Write("Введите username:");
string username = Console.ReadLine();
if(username == "Маша")
{
    Console.WriteLine("Ура! Цэ ж Маша!");
}
else
{
    Console.Write("Ну, привет ");
    Console.Write(username);
}
*/

/**/
Console.Write("Введите username:");
string? username = Console.ReadLine();
if(username!.ToLower() == "маша")
{
    Console.WriteLine("Ура! Цэ ж МАША!");
}
else
{
    Console.Write("Ну, привет ");
    Console.Write(username);
}
/**/