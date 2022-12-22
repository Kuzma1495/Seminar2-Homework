// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.(можно использовать индексацию строк)


Console.WriteLine("Введите число"); //Решение неполное, договорились разобрать на лекции
int a = Convert.ToInt32(Console.ReadLine());

if(a < 100) Console.WriteLine("Третьей цифры нет");

if(a > 99 && a < 1000) 
{
   int a3 = a % 10;
    Console.WriteLine(a3);
}
else
{
    int b = a / 10;
    int a3 = b % 10;
     Console.WriteLine(a3);
}


