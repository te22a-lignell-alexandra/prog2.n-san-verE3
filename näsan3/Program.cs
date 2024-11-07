using System.Runtime.InteropServices;

string[] Words = ["donkey", "idiotsandwich", "lambsauce", "mold"];

Console.WriteLine(GetChoice(Words));



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

static int GetNumberInput()
{
    System.Console.WriteLine("a number. please");
    string number = Console.ReadLine();
    int numberInt = 0;
    bool valid = int.TryParse(number, out numberInt);

    while (valid == false)
    {
        System.Console.WriteLine("number.");
        number = Console.ReadLine();
        valid = int.TryParse(number, out numberInt);
    }

    return numberInt;
}


static int GetChoice(string[] Stuff)
{
    for (int i = 0; i < Stuff.Length; i++)
    {
        System.Console.WriteLine($"{i+1}: {Stuff[i]}");
    }
    System.Console.WriteLine("choose. please");
    string choice = Console.ReadLine();
    int number = 0;
    bool valid = int.TryParse(choice, out number);
    while (valid == false || number > Stuff.Length)
    {
        System.Console.WriteLine("no. choose.");
        choice = Console.ReadLine();
        valid = int.TryParse(choice, out number);
    }

    int returnValue = 0;
    for (int i = 0; i < Stuff.Length; i++)
    {
        if (number == i + 1)
        {
            returnValue = i+1;
        }
    }

    return returnValue;
}