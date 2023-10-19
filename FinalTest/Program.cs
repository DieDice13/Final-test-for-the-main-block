﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



// Задаем массив строк
string[] strings = { "Hello", "2", "world", ":-)" };

// Подсчитываем количество строк, длина которых меньше или равна 3
int count = 0;
for (int i = 0; i < strings.Length; i++)
{
    if (strings[i].Length <= 3)
    {
        count++;
    }
}