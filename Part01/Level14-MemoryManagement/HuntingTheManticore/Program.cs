int round = 1;
int manticoreHealth = 10;
int consolasHealth = 15;

int manticoreRange = ManticorePilotInputRange(0, 100);
Console.Clear();

Console.WriteLine("Consolas defender, it is your turn.");
while (consolasHealth > 0 && manticoreHealth > 0)
{
    DisplayStatus(round, consolasHealth, manticoreHealth);

    int cannonDamage = CannonDamage(round);
    Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round");

    Console.Write("Enter desired cannon range: ");
    int cannonRange = Convert.ToInt32(Console.ReadLine());

    EvaluateShot(cannonRange, manticoreRange, cannonDamage);

    if (manticoreHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Manticore has been destroyed! The City of Consolas has been saved!");
        return;
    }

    consolasHealth -= 1;
    if (consolasHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("The City of Consolas fell!");
        return;
    }

    round++;
}

int ManticorePilotInputRange(int min, int max)
{
    int manticoreRange;
    do
    {
        Console.Write("Manticore Pilot, input the location coordinates where airship will be located: ");
        manticoreRange = Convert.ToInt32(Console.ReadLine());
    } while (manticoreRange < min || manticoreRange > max);

    return manticoreRange;
}


void DisplayStatus(int round, int consolasHealth, int manticoreHealth)
{
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {round} | City: {consolasHealth}/15 | Manticore: {manticoreHealth}/10");
}

int CannonDamage(int round)
{
    int fireTurn = 3;
    int electricTurn = 5;
    int combinedTurn = fireTurn * electricTurn;

    int cannonDamage = 1;


    if (round % combinedTurn == 0)
    {
        cannonDamage = 10;
    }
    else if (round % fireTurn == 0)
    {
        cannonDamage = fireTurn;
    }
    else if (round % electricTurn == 0)
    {
        cannonDamage = electricTurn;
    }

    return cannonDamage;
}

void EvaluateShot(int cannonRange, int manticoreRange, int cannonDamage)
{
    if (cannonRange < manticoreRange)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"That round FELL SHORT of the target");
    }

    else if (cannonRange > manticoreRange)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"That round OVERSHOT the target");
    }
    else if (cannonRange == manticoreRange)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"That round was a DIRECT HIT!");
        manticoreHealth -= cannonDamage;
    }

    Console.ResetColor();
}