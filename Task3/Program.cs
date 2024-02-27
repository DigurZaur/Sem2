//Программа, которая принимает 2 числа и выводит
//является ли второе число кратно первому.
//В противном случае выводит остаток

System.Console.WriteLine("Введите первое число:");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int x2 = Convert.ToInt32(Console.ReadLine());                        //аналог Convert.ToInt32 = int.Parse
int ost = x2 % x1;
if (ost == 0)
{
    System.Console.WriteLine("Число " + x2 + " кратно " + x1);       //Конкатенация
}
else
{
    System.Console.WriteLine($"Число {x2} не кратно {x1}");          //Интерполяция
    System.Console.WriteLine("Остаток от деления = " + ost);
}