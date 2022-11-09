// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int SumNum(int num)
{
    int num1 = 0;
    while(num!=0)
    {
        num1 += num%10;
        num /=10;
    
    }
return num1;
}
Console.WriteLine("Сумма чисел" + SumNum(number));