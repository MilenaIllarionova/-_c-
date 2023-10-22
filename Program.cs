// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

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






/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
