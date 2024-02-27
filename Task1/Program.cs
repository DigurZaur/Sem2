// Программа выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа 

int ran = new Random().Next(10,100);    //Второе числа на 1 больше
System.Console.WriteLine(ran);

int first = ran / 10;
int second = ran % 10;

if(first > second)
{
    System.Console.WriteLine(first);
}
else
{
    System.Console.WriteLine(second);
}