double FindDistance(double x, double y, double x1, double y1)
{
    double a = x1 -x;
    double b = y1 - y;
    double distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
    return distance;
}
Console.WriteLine(FindDistance(4, 9, -5, 0));
