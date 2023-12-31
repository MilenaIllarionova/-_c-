﻿/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

internal class Program
{
    static void PrintNumbers(int n){
       string PrintNumbers(int number_start, int number_end){
            if(number_start == number_end){
                return number_start.ToString();
            }
            return number_start+ " "+ PrintNumbers(number_start + 1, number_end);
        }
        System.Console.WriteLine(PrintNumbers(1, n));
    }
    static void Main(string[] args)
    {
        Console.Write("Введите натуральное число: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 1){
            Console.WriteLine("Ошибка: введено отрицательное число.");
            return;
        }
         PrintNumbers(n);
    }
}
*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine("Сумма натуральных элементов в промежутке от {0} до {1} равна {2}", m, n, sum);

        Console.ReadKey();
    }
}*/


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static void Main(string[] args)
    {
        Random rand = new Random();
        int m = rand.Next(0, 10);
        int n = rand.Next(0, 10);

        Console.WriteLine("Вычисление функции Аккермана для m = {0} и n = {1}", m, n);
        Console.WriteLine("Результат: {0}", Ackermann(m, n));

        Console.ReadKey();
    }
}*/

