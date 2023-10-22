/*
28. Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/
Console.Clear();
int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void Prod(int arg){
    int prod = 1;
    for (int i = 1; i <= arg; i++)
    {
        prod = prod * i;
    }
    System.Console.WriteLine(prod);
}
int number = Prompt("Введите число: ");
Prod(number);