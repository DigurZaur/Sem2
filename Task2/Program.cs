// Программа, которая выводит случайное
// трехзначное число и удаляет вторую цифру

int num = new Random().Next(100, 1000);
System.Console.WriteLine(num);

int first = num / 100 * 10;
int third = num % 10;
int result = (first + third);
System.Console.WriteLine(result);