/*
29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]
*/
void CreateArray(int[] numbers) {
    int length = numbers.Length;
    int index = 0;
    while (index < length) {
        numbers[index] = new Random().Next(0, 100);
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