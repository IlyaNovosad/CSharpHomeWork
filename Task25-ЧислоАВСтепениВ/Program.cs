/*
25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Clear();
int Prompt(string message){
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
/*
void Degree(int arg1, int arg2){
    double degree = Math.Pow(arg1, arg2);
    System.Console.WriteLine(degree);
}
*/
void Degree(int arg1, int arg2){
    double degree = arg1;
    for (int i = 1; i < arg2; i++){
        degree *= arg1; 
    }
    System.Console.WriteLine(degree); 
}
int numberOne = Prompt("Введите число А: ");
int numberTwo = Prompt("Введите число В: ");
Degree(numberOne, numberTwo);