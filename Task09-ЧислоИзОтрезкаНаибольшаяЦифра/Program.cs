/*
09. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
*/
/*
int randomNumber = new Random().Next(10, 99);
Console.WriteLine(randomNumber);
int firstNumber = randomNumber / 10;
int seconNumber = randomNumber % 10;
if (firstNumber > seconNumber) {
    Console.WriteLine(firstNumber);
} else {
    Console.WriteLine(seconNumber);
}
*/
int RandomNumber() {
    int newRandom =new Random().Next(10, 99);
    return newRandom;
}

int FindMax(int newRandom) {
    int firstNumber = newRandom / 10;
    int seconNumber = newRandom % 10;
    if (firstNumber > seconNumber) {
        return firstNumber;
    } else {
        return seconNumber;
    }
}
int number = RandomNumber();
Console.WriteLine(number);
Console.WriteLine(FindMax(number));
