/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

Console.Write("Введите трёхзначное чило : ");
int number = int.Parse(Console.ReadLine());

number /= 10;
number %= 10;
Console.WriteLine(number);

