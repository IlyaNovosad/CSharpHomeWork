﻿/* Внутри класса Answer напишите метод CompareNumbers, 
* который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
* a = 5; b = 7 -> Первое число 5 меньше чем второе число 7
* a = 2; b = 2 -> Введенные числа равны 2
*/
Console.Write("Введите перове из двух чисел для проверки:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число для проверки: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber) {
    Console.WriteLine($"Первое число{firstNumber} равно вторму числу {secondNumber}");
} else {
    if (firstNumber > secondNumber) {
        Console.WriteLine($"Первое число{firstNumber} больше второго числа {secondNumber}");
    } else {
        Console.WriteLine($"Первое число{firstNumber} меньше второго числа {secondNumber}");
    }
}