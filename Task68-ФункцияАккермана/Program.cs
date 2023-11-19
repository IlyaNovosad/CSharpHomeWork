/*
68 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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
int Ackerman(int mNum, int nNum)
{
    if (mNum == 0)
    {
        return nNum + 1;
    }
    else if (mNum != 0 && nNum == 0)
    {
        return Ackerman(mNum - 1, 1);
    }
    else
    {
        return Ackerman(mNum - 1, Ackerman(mNum, nNum - 1));
    }
}
Message("Введите число m: ");
int m = Number();
Message("Введите число n: ");
int n = Number();
int result = Ackerman(m, n);
System.Console.WriteLine(result);