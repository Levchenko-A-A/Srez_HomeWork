// Напишите программу, которая выводит строку введенную
//пользователем в обратном порядке

string str="Hello World";
Console.Write("Введите строку:");
str = Console.ReadLine()!;
char[] chars = str.ToCharArray();
Array.Reverse(chars);
string str2 = new string(chars);
Console.WriteLine(str2);