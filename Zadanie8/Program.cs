﻿//Напишите программу, которая считывает строку с клавиатуры и выводит
//на экран количество символов в этой строке.

string str;
Console.Write("Введите строку:");
str =Console.ReadLine()!;
Console.WriteLine($"Размер строки: {str.Length} символов.");