/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем

int number = new Random().Next(100, 1000);
int num1 = number / 10;
int num2 = num1 % 10;

Console.WriteLine(number);
Console.WriteLine(num1);
Console.WriteLine(num2);
*/
/*
int number = new Random().Next(10, 100000);
Console.WriteLine(number);
if (number < 100)
{
    Console.WriteLine($"В числе {number} нет, третьей цифры");
    return;
}
else if (number > 99 && number < 1000)
{
    int numb1 = number % 10;
    Console.WriteLine($"третья цифра {numb1}");
}
else if (number > 999 && number < 10000)
{
    int numb2 = (number % 100) / 10;
    Console.WriteLine($"третья цифра {numb2}");
}
else if (number > 9999 && number < 100000)
{
    int numb3 = (number % 1000) / 100;
    Console.WriteLine($"третья цифра {numb3}");
}
*/
