﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int size = 8;
int[] array = new int[size]; // Получается массив на size(8) элементов

for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100); // Заполняем массив  
    }

Console.WriteLine($"Заполненный массив: [ {String.Join(", ", array)}]");