﻿/* Внутри класса Answer напишите метод PrintEvenNumbers, 
* которая на вход принимает число (number), 
* а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.
*/
Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= number; i = i + 2) {
    Console.Write(i + " ");
}