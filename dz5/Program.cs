string GetDistance3D(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double firstDot = Math.Pow(x2-x1, 2);
    double secondDot = Math.Pow(y2-y1, 2);
    double thirdDot = Math.Pow(z2-z1, 2);
    double distance = Math.Sqrt(firstDot + secondDot + thirdDot);
    return $"{distance}";
}

string GetDistance2D(int x1, int x2, int y1, int y2)
{
    double firstDot = Math.Pow(x2-x1, 2);
    double secondDot = Math.Pow(y2-y1, 2);
    double distance = Math.Sqrt(firstDot + secondDot);
    return $"{distance}";
}

string GetDistance1D(int x1, int x2)
{
    double firstDot = Math.Pow(x2-x1, 2);
    double distance = Math.Sqrt(firstDot);
    return $"{distance}";
}

string GetDistance4D(int x1, int x2, int y1, int y2, int z1, int z2, int t1, int t2)
{
    double firstDot = Math.Pow(x2-x1, 2);
    double secondDot = Math.Pow(y2-y1, 2);
    double thirdDot = Math.Pow(z2-z1, 2);
    double fourthDot = Math.Pow(t2-t1, 2);
    double distance = Math.Sqrt(firstDot + secondDot + thirdDot + fourthDot);
    return $"{distance}";
}

void D3()
{
    Console.Write("Введите координаты первой точки в 3D пространстве: x = ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y = ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("z = ");
    int z1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координаты второй точки в 3D пространстве: x = ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y = ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("z = ");
    int z2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(GetDistance3D(x1,x2,y1,y2,z1,z2));
}

void D2()
{
    Console.Write("Введите координаты первой точки в 2D пространстве: x = ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y = ");
    int y1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координаты второй точки в 2D пространстве: x = ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y = ");
    int y2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(GetDistance2D(x1,x2,y1,y2));
}

void D1()
{
    Console.Write("Введите координаты первой точки в 1D пространстве: x = ");
    int x1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координаты второй точки в 1D пространстве: x = ");
    int x2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(GetDistance1D(x1,x2));
}

void D4()
{
    Console.Write("Введите координаты первой точки в 4D пространстве: x = ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y = ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("z = ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("t = ");
    int t1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координаты второй точки в 4D пространстве: x = ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y = ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("z = ");
    int z2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("t = ");
    int t2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(GetDistance4D(x1,x2,y1,y2,z1,z2,t1,t2));
}

Console.Write("Введите число, которое задает пространство: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N == 3) D3();
else if (N == 2) D2();
else if (N == 4) D4();
else if (N == 1) D1();
