// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void SolveEquation(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;

    Console.WriteLine($"Заданные значения: b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} ");
    Console.WriteLine($"Точка пересения --> ({x}, {y})");
}

SolveEquation(b1: 2, k1: 5, b2: 4, k2: 9);