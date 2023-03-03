Console.Write("Введите число a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
double c = double.Parse(Console.ReadLine());

Console.Write("a) ");
if (c > b && b > a) Console.WriteLine("Условие выполняется");
else Console.WriteLine("Условие не выполняется");
Console.Write("б) ");
if (b > a && a > c) Console.WriteLine("Условие выполняется");
else Console.WriteLine("Условие не выполняется");