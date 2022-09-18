// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write ("Введите положительное значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите положительное значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

if ((M < 0) || (N < 0) )
{ 
    Console.WriteLine ("Вы ввели не натуральные числа");
}
if ((N>M) && ((M>0) && (N>0)))
for (int i = M; i <= N; i++)
    Console.Write($" {i}");
else
if ((M>0) && (N>0))
    for (int i = N; i <= M; i++)
        Console.Write($" {i}");

