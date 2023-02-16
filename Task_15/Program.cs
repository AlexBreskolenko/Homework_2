/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.Clear();

bool flag = false;

while(!flag)
{
    Console.WriteLine("Введите день недели от 1 до 7 : ");
    int day = int.Parse(Console.ReadLine());

    if (day == 6 || day == 7)
    {
        Console.WriteLine("Выходной день.");
        break;
    }
    else if (day > 0 && day < 6)
    {
        Console.WriteLine("Будний день.");
        break;
    }
    else
    {
        Console.WriteLine("Ошибка ввода, пожалуйста повторите ввод.");
    }
}
