/*
10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondPosition (int nuber) {
    if (number > 0 && number < 1000) {
        int firstPosition = nuber / 10;
        int secondPosition = firstPosition % 10;
        return secondPosition;
    } else {
        Console.WriteLine($"Число {number} не трехзначное.");
        return 0;
    }
}

Console.WriteLine(SecondPosition(number));
