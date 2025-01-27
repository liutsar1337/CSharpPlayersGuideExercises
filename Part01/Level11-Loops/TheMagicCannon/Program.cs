int fireTurn = 3;
int electricTurn = 5;
int combinedTurn = fireTurn * electricTurn;

for (int i = 1; i <= 100; i++)
{
    string cannonOutput = "Normal";
    Console.ForegroundColor = ConsoleColor.Gray;

    if (i % combinedTurn == 0)
    {
        cannonOutput = "Electric and Fire";
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    else if (i % fireTurn == 0)
    {
        cannonOutput = "Fire";
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else if (i % electricTurn == 0)
    {
        cannonOutput = "Electric";
        Console.ForegroundColor = ConsoleColor.Yellow;
    }

    Console.WriteLine($"{i}: {cannonOutput}");
}