

using System;


// Задача 1 Сдвиг точки по вектору от конца к началу
//Vector a = new Vector(3, 1);
//double ofset = 1;
//Point resultPoint = Point.OfsetPointByVector(ofset, a);

//Console.WriteLine($"Исходный вектор v1 ({a.X}, {a.Y})");

//Console.WriteLine($"При заданном смещении точки по вектору на {ofset} \n" +
//    $"новые координаты точки ({Math.Round(resultPoint.X,2)}, {Math.Round(resultPoint.Y,2)})");

//// Задание 2 поворот точки 2 вокруг точки 1
//Point p1 = new Point(2, 2);
//Point p2 = new Point(6, 2);
//double angle = 110;
//Console.WriteLine($"Исходные точки (({p1.X}, {p1.Y}) и ({p2.X}, {p2.Y}))");
//Point resultPoint = Point.RotationOfPointOnAngle(p1, p2, angle);
//Console.WriteLine($"Новая кордината точки  ({p2.X}, {p2.Y}))");
//Console.WriteLine($"после поворота на {angle} градусов  ({Math.Round(resultPoint.X, 1)}, {Math.Round(resultPoint.Y, 1)}))");


// Задание 3 проверка на перпендикулярность
Vector v1 = new Vector(5, 5);
Vector v2 = new Vector(-2, 2);
Console.WriteLine($"Исходный вектор v1 ({v1.X}, {v1.Y})");
Console.WriteLine($"Исходный вектор v2 ({v2.X}, {v2.Y})");

Vector.PerpendicularityOfTwoVectors(v1, v2);


Console.ReadKey();



public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    /// <summary>
    /// Перемещает точку p2 на заданный угол по отношению к p1 точке
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public static Point RotationOfPointOnAngle(Point p1, Point p2, double angle)
    {
        double radians = angle * Math.PI / 180;
        double x = Math.Cos(radians) * (p2.X - p1.X) - Math.Sin(radians) * (p2.Y - p1.Y) + p1.X;
        double y = Math.Sin(radians) * (p2.X - p1.X) + Math.Cos(radians) * (p2.Y - p1.Y) + p1.Y;
        return new Point (x, y);

    }

    /// <summary>
    /// Смещение точки по вектору
    /// </summary>
    /// <param name="ofset"></param>
    /// <param name="a"></param>
    /// <returns></returns>
    public static Point OfsetPointByVector(double ofset, Vector a)
    {

        double length = Math.Sqrt(a.X * a.X + a.Y * a.Y);

        if (ofset < length && ofset >= 0)
        {
            return new Point(a.X / length * (length - ofset), a.Y / length * (length - ofset)); ;
        }
        else
        {
            Console.WriteLine("Выход точки за пределы вектора");
            return new Point(0, 0);
        }
    }
}


public class Vector
{
    public double X { get; set; }
    public double Y { get; set; }

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }



    /// <summary>
    /// Проверка двух векторов на перпендикулярность
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public static void PerpendicularityOfTwoVectors(Vector a, Vector b)
    {

        if ((a.X * b.X + a.Y * b.Y) == 0)
        {
            Console.WriteLine($"Векторы перпендикулярны");
        }
        else Console.WriteLine($"Векторы не перпендикулярны");



    }

}


