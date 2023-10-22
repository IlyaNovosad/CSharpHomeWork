/*
30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
*/
void CreateArray(int[] numbers) {
    int length = numbers.Length;
    int index = 0;
    while (index < length) {
        numbers[index] = new Random().Next(0, 2);
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
int[] array = new int[8];
CreateArray(array);
PrintArray(array);