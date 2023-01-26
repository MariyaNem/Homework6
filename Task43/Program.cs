// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double resX = CrossLinePointX(b1, k1, b2, k2);
double resY = CrossLinePointY(b1, k1, resX);

if (k1 == k2 && b1 == b2) Console.WriteLine("Линии совпадают");
else if (k1 == k2) Console.WriteLine("Линии параллельны");
else Console.Write($"Точка пересечения двух прямых: ({resX}; {resY})");


double CrossLinePointX(double numb1, double numk1, double numb2, double numk2)
{
    double x = (numb2 - numb1) / (numk1 - numk2);
    return x;
}

double CrossLinePointY(double numb1, double numk1, double x)
{
    double y = numk1 * x + numb1;
    return y;
}
