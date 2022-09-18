// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write ("Введите положительное значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите положительное значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({M}, {N}) = {Akkerman(M, N)}");
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
   else if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0)
            return Akkerman(m - 1, Akkerman(m, n - 1));
            else return n +1;
}