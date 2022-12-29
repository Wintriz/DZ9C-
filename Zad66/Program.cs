﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Console.WriteLine(PrintNumbers(m, n));

int PrintNumbers(int start, int end)
{
    if (start == end) return end;
    return (start + PrintNumbers(start + 1, end));
}