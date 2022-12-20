// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if(a < 100 || a > 999) Console.WriteLine("Введите трёхзначное число");

else
{
    int a1 = a / 100;
    int a2 = a / 10;
    int a3 = a % 10;

    int b = a2 % 10;



    Console.WriteLine(b);
}


