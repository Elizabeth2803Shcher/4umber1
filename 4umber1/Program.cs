// See https://aka.ms/new-console-template for more information
Console.WriteLine("Дано четырехзначное число. Найти: а) сумму его цифр; б) произведение его цифр.");
Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine());
int d = n % 10;
int c = n % 100 / 10;
int b = n % 1000 / 100;
int a = n / 1000;

Console.Write("а) Сумма цифр введенного числа равна:");
Console.WriteLine(a + b + c + d);
Console.Write("б) Произведение цифр введенного числа равна:");
Console.WriteLine(a * b * c * d);