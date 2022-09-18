// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write ("Введите положительное значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите положительное значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
if ((M < 0) || (N < 0) )
{ 
    Console.WriteLine ("Вы ввели не натуральные числа");
}
if ((N>M) && ((M>0) && (N>0)))
for (int i = M; i <= N; i++)
    Sum  = Sum + M++;
else
if ((M>0) && (N>0))
    for (int i = N; i <= M; i++)
        Sum  = Sum + N++;
Console.WriteLine ($"Сумма натуральных элементов в промежутке от M до N: {Sum}");