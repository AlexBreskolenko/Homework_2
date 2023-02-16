/*
 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.Clear();

Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}
else if(num > 100 && num < 1000)
{
    Console.WriteLine(num % 10);
}
else
{
    while(num > 999)
    {
        num /= 10;
    }

    Console.WriteLine(num % 10);
}