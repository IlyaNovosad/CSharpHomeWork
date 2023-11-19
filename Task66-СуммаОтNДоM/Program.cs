/*
66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int Number()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void Message(string arg)
{
    string message = arg;
    Console.Write(message);
}
int SumNumber(int numM, int numN)
{
    if (numM <= numN)
    {
        return numM + SumNumber(numM + 1, numN);
    }
    else return 0;
}
Message("Введите число M: ");
int m = Number();
Message("Введите число N: ");
int n = Number();
int result = SumNumber(m, n);
Console.WriteLine(result);