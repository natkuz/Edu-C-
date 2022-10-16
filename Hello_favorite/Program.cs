Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")// ToLower - Переводит все символы в нижний регистр
{
    Console.WriteLine("Ура, к нам Маша пришла!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}