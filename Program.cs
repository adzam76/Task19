﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 10000;
int b = n % 10;
int c = n /1000;
int d = c % 10;
int e = n / 10;
int f = e % 10;
if (a == b && d == f)
{
   Console.WriteLine($"число {n} является палиндромом");
}
else
{
    Console.WriteLine($"число {n} не является палиндромом");
}
