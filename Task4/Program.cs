//Программа, которая принимает значение
//и проверяет кратно ли оно одновременно
//7 и 23.

System.Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)          //  && - и      || - или
{
    System.Console.WriteLine($"Число {num} кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"Чисто {num} не кратно 7 и 23");
}

