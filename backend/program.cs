// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Меня зовут Рыхлюк Н.В.");
// Console.WriteLine(DateTime.Now);

// Console.Write("Введите имя: ");
// string name = Console.ReadLine();
// Console.WriteLine($"Привет,{name}");

// Console.WriteLine(DateTime.Now.ToString("dddd"));

Console.Write("Хотите продолжить? (y/n): ");
string a = Console.ReadLine();

if (a == "y")
{
    Console.WriteLine("Продолжаем!");  
}
else if (a == "n")
{
    Console.WriteLine("До свидания!");
    return; 
}
else
{
    Console.WriteLine("Неверный ввод Введите 'y' или 'n'.");
}
