﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите число");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int numB = int.Parse(Console.ReadLine());

int GetNum = numA;
for(int i=1;i<numB;i++)
{
    GetNum = GetNum*numA;
}
Console.WriteLine("А в степени В равно:"+GetNum);

