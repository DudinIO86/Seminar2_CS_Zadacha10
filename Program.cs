// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехначное число: ");
string strNum=Console.ReadLine();
int num=int.Parse(strNum);

if(num>99&&num<1000)
{
    int num1=num/10%10;
    Console.WriteLine($"Второе число числа {num} является {num1}");
}
else
{
    Console.WriteLine("Число не трехзначное");
}