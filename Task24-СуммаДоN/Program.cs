/*
24. Напишите программу, которая принимает на вход
число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
Console.Clear();
int Prompt(string message){
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void Summ(int arg){
    int summ = 0;
    for (int i = 1; i <= arg; i++){
        summ = summ + i;
    }
    System.Console.WriteLine(summ);
}
int userNumber = Prompt("Введите число N: ");
Summ(userNumber);