// 17. Напишите программу, которая принимает на вход координаты точки (X, Y), отличные от (0, 0),
// и выдаёт номер четверти плоскасти, в которой находится эта точка.

Task17Method();

void Task17Method()
{
        Console.WriteLine("Enter coordinates (X, Y) not equal to (0, 0)");

        int x = ReadInt("X: ");
        int y = ReadInt("Y: ");

        if (x*y == 0)
        {
            System.Console.WriteLine("The coordinates should not be equal to 0");
        }
        else
        {
            System.Console.WriteLine($"Coordinates ({x}, {y}) are in the quarter {GetQuarter(x, y)}");
        }
}

int GetQuarter(int x, int y)
{
    switch ((x, y))
    {
        case (> 0, > 0):
            return 1;

        case (< 0, > 0):
            return 2;

        case (< 0, < 0):
            return 3;

        case (> 0, < 0):
            return 4;

        case (0, 0):
            return -1;
    }

    return -1;
}

int ReadInt(string msg)
{
    int res = 0;
    
    System.Console.Write(msg);

    while (!int.TryParse(Console.ReadLine(), out res))
    {
        System.Console.WriteLine("Imput error. Enter an integer number.");
        System.Console.Write(msg);
    }

    return res;
}