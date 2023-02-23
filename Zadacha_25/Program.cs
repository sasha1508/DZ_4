// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int VozvedenieVStepen(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

Console.Clear();

Console.Write("Введи число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} в сепени {b} равняется: {VozvedenieVStepen(a, b)}");