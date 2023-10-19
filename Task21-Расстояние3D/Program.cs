/*
21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
double Range(int xA, int yA, int zA, int xB, int yB, int zB){
    double sqrX = Math.Pow(xA - xB, 2);
    double sqrY = Math.Pow(yA - yB, 2);
    double sqrZ = Math.Pow(zA - zB, 2);
    double sqrt = Math.Sqrt(sqrX + sqrY + sqrZ);
    System.Console.WriteLine(Math.Round(sqrt, 2));
    return 1;
}

int xA = Prompt("Координата X для точки A: ");
int yA = Prompt("Координата Y для точки A: ");
int zA = Prompt("Координата Z для точки A: ");
int xB = Prompt("Координата X для точки B: ");
int yB = Prompt("Координата Y для точки B: ");
int zB = Prompt("Координата Z для точки B: ");
/*
System.Console.WriteLine("A (" + xA + ", " + yA + ", " + zA + ")");
System.Console.WriteLine("B (" + xB + ", " + yB + ", " + zB + ")");
*/
System.Console.Write($"Расстояние между точками A ({xA}, {yA}, {zA}) и точко B ({xB}, {yB}, {zB}) равно: ");
System.Console.WriteLine(Range(xA, yA, zA, xB, yB, zB));