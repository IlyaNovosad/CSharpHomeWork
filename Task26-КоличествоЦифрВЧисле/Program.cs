/*
26. Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
Console.Clear();
int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void Quantity(int arg)
{
    int quantity = 0;
    for (int i = arg; i > 0; i = i / 10)
    {
        quantity = quantity + 1;
    }
    System.Console.WriteLine(quantity);
}
int number = Prompt("Введите число: ");
Quantity(number);