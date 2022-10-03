// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


using static System.Console;
Clear();
Write("Введите значение b1: ");
double b1 = int.Parse(ReadLine()!);
Write("Введите значение k1: ");
double k1 = int.Parse(ReadLine()!);
Write("Введите значение b2: ");
double b2 = int.Parse(ReadLine()!);
Write("Введите значение k2: ");
double k2 = int.Parse(ReadLine()!);
double resX = SearchX(b1, k1, b2, k2);
double resY = SearchY(b1, k1, b2, k2);

WriteLine($"Точка пересечения: ({resX}; {resY})");


double SearchX(double B1, double K1, double B2, double K2)
{
    double X = (B2-B1)/(K1-K2);
    return X;
}

double SearchY(double Bb1, double Kk1, double Bb2, double Kk2)
{
    double Y = Kk1 * (Bb2-Bb1) / (Kk1-Kk2) + Bb1;
    return Y;
}



