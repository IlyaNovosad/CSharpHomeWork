/*
Напишите программу, которая на вход получает число N, а на выходе показывает вме числа в промежутке от -N до N.
*/

Console.Write("Введите с клавиатуры число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
for (int i = - userNumber1; i <= userNumber1; i++) {
    Console.Write(i + " ");
}