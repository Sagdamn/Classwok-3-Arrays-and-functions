/* Задача 21: Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 //A (3,6) - x = 3, y = 6
A (7,-5); B (1,-1) -> 7,21

AB = √(x2 - x1)2 + (y2 - y1)2 */

/*
1. Определяем, что есть 2 точки Х и У
2. Получаем координаты этих точек
3. Объявляем переменную, которая будет отвечать за расстояние между 2мя точками

*/

/* void GetDistanceBetweenTwoPoints(int firstX, int secondX, int firstY, int secondY)
{
    double result = 0;

    int tempX = Math.Pow(secondX - firstX, 2); //(secondX - firstX)*(secondX - firstX)
    int tempY = Math.Pow(secondY - firstY, 2);  //Math.Sqrt - вычисление корня ; Math.Pow - возведение в квадрат

    result = Math.Sqrt(tempX + tempY);

    Console.WriteLine($"Расстояние между двумя точками = {result}");
}

GetDistanceBetweenTwoPoints(3, 2, 6, 1); */

void GetDistanceBetweenTwoPoints(int firstX, int secondX, int firstY, int secondY)
{
    double result = 0;

    int tempX = (secondX - firstX) * (secondX - firstX);
    int tempY = (secondY - firstY) * (secondY - firstY);

    result = Math.Sqrt(tempX + tempY);

    Console.WriteLine($"расстояние между двумя точками = {result}");
}

GetDistanceBetweenTwoPoints(7, 1, -5, -1);

/* вариант Ильи
void GetDistanceBetweenTwoPoints(int firstX, int secondX, int firstY, int secondY)
{
double result = 0;

int tempX = (secondX - firstX) * (secondX - firstX);
int tempY = (secondY - firstY) * (secondY - firstY);

result = Math.Sqrt(tempX + tempY);

Console.WriteLine($"расстояние между двумя точками = {result}");
}

Point GetPoint()
{
Point point = new Point();
Console.WriteLine("Введите координату Х:");
point.X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату У:");
point.Y = int.Parse(Console.ReadLine());

return point;
}


Point firstPoint = GetPoint();
Point secondPoint = GetPoint();

double result = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y,2));
Console.WriteLine(result);

class Point
{
public int X { get; set;}
public int Y { get; set;}
}
*/