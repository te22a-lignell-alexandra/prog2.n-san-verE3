
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

static int GetChoice(string donkey, string idiotsandwich, string lambsauce)
{
    System.Console.WriteLine($"{donkey}\n{idiotsandwich}\n{lambsauce}\n");
    System.Console.WriteLine("Choose. please");
    string choice = Console.ReadLine().ToLower();
    while (choice != donkey || choice != idiotsandwich || choice != lambsauce)
    {
        System.Console.WriteLine($"Choose. (hint. write {donkey}, {idiotsandwich}, or {lambsauce})");
        choice = Console.ReadLine().ToLower();
    }
    if (choice == donkey) return 1;
    else if (choice == idiotsandwich) return 2;
    else return 3;
}