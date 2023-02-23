// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Находим count:
int countOfChislo(int chislo1)
{
    int countTemp = 0;
    int rezultTemp = 1;
    int i = 10;
    while (rezultTemp > 0)
    {
        rezultTemp = chislo1 / i;
        i = i * 10;
        countTemp ++;
    }

    return countTemp;
}

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

Console.Write("Введи число: ");
int chislo = Convert.ToInt32(Console.ReadLine());

int count = countOfChislo(chislo);
int sum =0;

for (int i = 0; i < count; i++)
{
    sum += chislo / VozvedenieVStepen(10, i) % 10;
}

Console.WriteLine($"Сумма цифр числа {chislo} равна: {sum}");