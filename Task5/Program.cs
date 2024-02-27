// Программа, принимает 2 числа и проверяет
// является ли одно число квадратом другого

System.Console.WriteLine("Введите первое число:");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int x2 = Convert.ToInt32(Console.ReadLine());
if (x2 == x1 * x1)
{
    System.Console.WriteLine($"Число {x2} является квадратом числа {x1}");
}
else if (x1 == x2 * x2)
{
    System.Console.WriteLine($"Число {x1} является квадратом числа {x2}");
}
else
{
    System.Console.WriteLine("Ни одно из чисел не является квадратом другого");
}