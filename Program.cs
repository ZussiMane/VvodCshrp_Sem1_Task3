// Напишите программу, которая принимает на вход 
// трёхзначное целое число и на выходе показывает сумму 
// первой и последней цифры этого числа.

// 456 => 10
// 782 => 9
// 918 => 17

// Мое читерское решение ) 
// using System.Diagnostics.CodeAnalysis;

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int sum = num1 + num3;
// Console.Write("Сумма первого и третьего чисел равна: ");
// Console.WriteLine(sum);

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num >= 100 && num <= 999) || (num >= -999 && num <= -100)) // && - "и", || - "или"(проверка на трехзначность числа (диапазон))
{
    int firstDigit = num / 100; // Первое целое число
    int lastDigit = num % 10; // %10 - остаток от деления на 10(получаем третье число)
    int sum = firstDigit + lastDigit;
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Некорректное число!");
}
