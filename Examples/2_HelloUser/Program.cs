/* Нам необходимо создать "контейнер" для хранения данных, которые вводит пользователь
Console.WriteLine("Введите ваше имя");
string? username = Console.ReadLine();
// Далее выводим приветствие в консоль
Console.WriteLine("Привет, ");
Console.WriteLine(username);
// Воспользуемся командой Write, чтобы не переходить на новую строку */
Console.WriteLine("Введите ваше имя");
string? username = Console.ReadLine();
Console.Write("Привет, ");
Console.Write(username);