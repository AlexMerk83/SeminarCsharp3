// 17. Напишите программу, которая принимает на вход координаты точки (X, Y), отличные от (0, 0),
// и выдаёт номер четверти плоскасти, в которой находится эта точка.

int X = 0, Y = 0;

Console.WriteLine("Enter coordinates (X, Y) not equal to (0, 0)");

Console.Write("X: ");

while (!int.TryParse(Console.ReadLine(), out X) || X == 0)
{
    System.Console.WriteLine("Enter integer number other than 0");
    Console.Write("X: ");
}

Console.Write("Y: ");

while (!int.TryParse(Console.ReadLine(), out Y) || Y == 0)
{
    System.Console.WriteLine("Enter integer number other than 0");
    Console.Write("Y: ");
}

switch ((X, Y))
{
    case (> 0, > 0):
    {
        System.Console.WriteLine($"Coordinates ({X}, {Y}) are in the quarter 1");
        break;
    }
    case (< 0, > 0):
    {
        System.Console.WriteLine($"Coordinates ({X}, {Y}) are in the quarter 2");
        break;
    }
    case (< 0, < 0):
    {
        System.Console.WriteLine($"Coordinates ({X}, {Y}) are in the quarter 3");
        break;
    }
    case (> 0, < 0):
    {
        System.Console.WriteLine($"Coordinates ({X}, {Y}) are in the quarter 4");
        break;
    }
    case (0, 0):
    {
        System.Console.WriteLine($"Error. Coordinates ({X}, {Y})");
        break;
    }
}
