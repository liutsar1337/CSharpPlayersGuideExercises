Console.Write("Enter x value: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y value: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Coordinates are: x={x}, y={y}");

if (x == 0)
{
    if (y > 0)
        Console.WriteLine("The enemy is to the north!");
    else if (y == 0)
        Console.WriteLine("The enemy is here!");
    else if (y < 0)
        Console.WriteLine("The enemy is to the south!");
}
else if (x < 0)
{
    if (y > 0)
        Console.WriteLine("The enemy is to the northwest!");
    if (y == 0)
        Console.WriteLine("The enemy is to the west!");
    if (y < 0)
        Console.WriteLine("The enemy is to the southwest!");
}
else if (x > 0)
{
    if (y > 0)
        Console.WriteLine("The enemy is to the northeast!");
    if (y == 0)
        Console.WriteLine("The enemy is to the east!");
    if (y < 0)
        Console.WriteLine("The enemy is to the southeast!");
}