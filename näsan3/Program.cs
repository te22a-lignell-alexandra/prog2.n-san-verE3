
System.Console.WriteLine(CircleArea(2));

Console.ReadLine();
// -------------------metoder-------------------

static void Hello32()
{
    for (int i = 0; i < 32; i++)
    {
        System.Console.WriteLine("Hello, World");    
    }
}

static int Matte(int number)
{
    int newNumber = number*number;
    return newNumber;
}

static float Multi(float faktor1, float faktor2)
{
    float newNumber = faktor1*faktor2;
    return newNumber;
}

static double RightTriangleArea(double b, double h)
{
    double area = (b*h)/2;
    return area;
}

static double CircleArea(double r)
{
    double area = r*r*Math.PI;
    return area;
}


