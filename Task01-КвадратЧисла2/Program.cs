/*
01. Напишите программу, которая на входи принимает два числа и проверяет,
является ли первое число квадратом второго.
*/
Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne == numberTwo * numberTwo)
{
    Console.WriteLine("Да, является квадратом второго числа");
} else 
{
    Console.WriteLine("Нет, не является квадратом второго числа");
}
