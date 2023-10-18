/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
*/
Console.Clear();
System.Console.WriteLine("Введите координаты точки A(x, y).");
int PointXA(){
    System.Console.Write("Введите координату X для точки А: ");
    int xA = Convert.ToInt32(Console.ReadLine());
    return xA;
}
int PointYA(){
    System.Console.Write("Введите координату Y для точки А: ");
    int yA = Convert.ToInt32(Console.ReadLine());
    return yA;
}
System.Console.WriteLine("Введите координаты точки B(x, y).");
int PointXB(){
    System.Console.Write("Введите координату X для точки B: ");
    int xB = Convert.ToInt32(Console.ReadLine());
    return xB;
}
int PointYB(){
    System.Console.Write("Введите координату Y для точки А: ");
    int yB = Convert.ToInt32(Console.ReadLine());
    return yB;
}
double Range(int xA, int yA, int xB, int yB){
    double sqrX = Math.Pow(xB - xA, 2);
    double sqrY = Math.Pow(yB - yA, 2);
    double sqrt = Math.Sqrt(sqrX + sqrY);
    System.Console.WriteLine(Math.Round(sqrt, 2));
    return 1;
}
int userXA = PointXA();
int userYA = PointYA();
int userXB = PointXB();
int userYB = PointYB();
System.Console.WriteLine(Range(userXA, userYA, userXB, userYB));