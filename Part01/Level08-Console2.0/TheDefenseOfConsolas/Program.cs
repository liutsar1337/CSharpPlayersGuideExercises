Console.Title = "Defense of Consolas";

Console.Write("Target Row? ");
int targetRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

void DisplayColoredCoordinates(ConsoleColor color, int row, int column)
{
    Console.ForegroundColor = color;
    Console.WriteLine($"{row}, {column}");
}

Console.WriteLine("Deploy squad members to: ");
DisplayColoredCoordinates(ConsoleColor.Red, targetRow, targetColumn - 1);
DisplayColoredCoordinates(ConsoleColor.Green, targetRow - 1, targetColumn);
DisplayColoredCoordinates(ConsoleColor.Blue, targetRow, targetColumn + 1);
DisplayColoredCoordinates(ConsoleColor.Yellow, targetRow + 1, targetColumn);

Console.Beep();