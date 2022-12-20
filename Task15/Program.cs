// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.


Console.WriteLine("Введите число!");
int a = Convert.ToInt32(Console.ReadLine());

if(a == 6 || a == 7) Console.WriteLine("Выходной");
else
    Console.WriteLine ("Будний день");
    


