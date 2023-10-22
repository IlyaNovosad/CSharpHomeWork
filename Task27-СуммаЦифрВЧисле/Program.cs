/*
27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Clear();
int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void Summ(int arg){
    int summ = 0;
    while (arg > 0)
    {
        summ += arg % 10;
        arg = arg / 10;
    }
    System.Console.WriteLine(summ);
}

int Req(int arg){
    if (arg < 10)
        return arg;
    int summ = arg % 10;
    int nextArg = arg / 10;
        return summ + Req(nextArg);
}
int number = Prompt("Введите число: ");
System.Console.WriteLine(Req(number));
Summ(number);