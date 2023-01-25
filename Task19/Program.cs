﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrome(int number)
{
    return ((number / 10000 == number % 10) && (number / 1000 % 10== number / 10 % 10));
}

Console.Write("введите число пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100000 && number > 9999)
{
    bool result = Palindrome(number);
    if (result == true) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
else Console.Write("Вы ввели не пятизначное число");
