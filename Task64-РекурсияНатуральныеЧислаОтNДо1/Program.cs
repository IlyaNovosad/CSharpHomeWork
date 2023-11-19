/*
64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int Number()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void Message()
{
    Console.Write($"Введите с клавиатуры число N: ");
}
void IntN(int number, int current = 1)
{
    if (number < current) return;
    else
    {
        System.Console.Write(number + " ");
        IntN(number - 1, current);
    }
}
Message();
int userNumber = Number();
IntN(userNumber);