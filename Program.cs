// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите трехзначное число");
string a_str = Console.ReadLine();
int length = a_str.Length;
int a = Convert.ToInt32(a_str);
Console.WriteLine();
if(length <= 2) Console.WriteLine("третьей цифры нет");
else 
{
    int i = 0;
    while(i< (length-3))
    {
    a = a/10;
    i ++;
    }
    Console.WriteLine(a%10);
}