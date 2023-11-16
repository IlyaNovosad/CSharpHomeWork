/*
65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
*/
Console.WriteLine("Введите число N: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

void intN(int number1, int number2)
{
    if (number2 >= number1)
    {
        Console.Write(number1 + " ");
        intN(number1 + 1, number2);
    }
    else
        return;
}

intN(numberOne, numberTwo);
/*
System.Console.WriteLine("Введите число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void intN(int first, int last)
{
    if (last >= first)
    {
        System.Console.Write(first + " ");
        intN(first +1, last);
    }
    else
        return;
}

intN(number1, number2);
*/