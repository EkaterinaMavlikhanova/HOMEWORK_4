﻿/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = numberRequest ("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);

int NumberLen(int a)
{
 int index = 0;
 while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
 int sum = 0;
 for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
 Console.WriteLine(sum);
}