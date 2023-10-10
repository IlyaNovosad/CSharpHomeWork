/*
Внутри класса Answer напишите метод CheckIfEven, 
который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).
*/
using System;
System.Console.Write("Введите число для проверки: ");
int number = Convert.ToInt32(Console.ReadLine());
int surPlus = number % 2;
if (surPlus > 0) {
    Console.WriteLine($"{number} нечетное!");
} else {
    Console.WriteLine($"{number} четное!");
}