/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем


int number = new Random().Next(100, 1000);
int num1 = number / 10;
int num2 = num1 % 10;

Console.WriteLine(number);
Console.WriteLine(num1);
Console.WriteLine(num2);
*/



/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решаем с помощью "/" и "%", 
со строками не работаем (Максимальное число 100000)


int number = new Random().Next(10, 100000);
Console.WriteLine($"Само число {number}");
if (number < 100)
{
    Console.WriteLine($"В числе {number} нет, третьей цифры");
    return;
}
else if (number > 99 && number < 1000)
{
    int numb1 = number % 10;
    Console.WriteLine($"В числе {number} третья цифра {numb1}");
}
else if (number > 999 && number < 10000)
{
    int numb2 = (number % 100) / 10;
    Console.WriteLine($"В числе {number} третья цифра {numb2}");
}
else if (number > 9999 && number < 100000)
{
    int numb3 = (number % 1000) / 100;
    Console.WriteLine($"В числе {number} третья цифра {numb3}");
}
*/



/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Обязательно сделать проверку на ввод чисел меньше 1 и больше 7


Console.WriteLine("Введите число недели");
int number= int.Parse (Console.ReadLine()!);
if(number>=1 && number<=7)
{
    if(number>=6)
    {
        Console.WriteLine($"Число {number} являеться выходным днём");
    } 
    else
    {
        Console.WriteLine($"Число {number} не являеться выходным днём");
    }  
}
else
{
    Console.WriteLine($"Число {number} не являеться днём недели");
}
*/