/*
31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/
void CreateArray(int[] numbers) {
    int length = numbers.Length;
    int index = 0;
    while (index < length) {
        numbers[index] = new Random().Next(-9, 10);
        index++;
    }

}
void PrintArray(int[] newcollection) {
    int count = newcollection.Length;
    int position = 0;
    Console.Write("[ ");
    while (position < count) {
        Console.Write(newcollection[position] + " ");
        position++;
    }
    Console.WriteLine("]");
}
int SumPosNum(int[] array){
    int result = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > 0) result += array[i];
    }
    return result;
}
int SumNegNum(int[] array){
    int result = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] < 0) result += array[i];
    }
    return result;
}
int[] array = new int[12];
CreateArray(array);
PrintArray(array);
Console.WriteLine("Сумма положительных элементов массива равна: " + SumPosNum(array) + "; " + "Сумма отрицательных элементов массива равна: " + SumNegNum(array));

/*
int Prompt(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    int pozitive = 0;
    int negative = 0;

    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");

        if (array[i] > 0)
            pozitive = pozitive + array[i];
        else
            negative = negative + array[i];
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма положительных чисел:\t {pozitive}");
    System.Console.WriteLine($"Сумма отрицательных чисел:\t {negative}");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значене для дапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);
*/

/*
using System;
Console.Clear();

int[] GetRandomArray(int start, int end, int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumPositiveNum (int[] array)
{
 
 int result = 0;
 for (int i = 0; i < array.Length; i++)
 {
    if (array[i] > 0) result +=array[i];
 }
 return result;
}

int SumNegativeNum (int[] array)
{
 
 int result = 0;
 for (int i = 0; i < array.Length; i++)
 {
    if (array[i] < 0) result +=array[i];
 }
 return result;
}

int userArraySize = TakeEntNum ("Please, enter array size:");
int userArrayStart = TakeEntNum ("Please, enter array start number range:");
int userArrayEnd =  TakeEntNum ("Please, enter array end number range:");

int[] userArray = GetRandomArray (userArrayStart, userArrayEnd, userArraySize);
PrintArray (userArray);

int posArraySum = SumPositiveNum(userArray);
int negArraySum = SumNegativeNum(userArray);

System.Console.WriteLine($"Sum of positive numbers {posArraySum}, sum of negative numbers {negArraySum}.");
*/