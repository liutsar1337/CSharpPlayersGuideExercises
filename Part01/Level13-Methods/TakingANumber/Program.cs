int result = AskForNumber("What year was the movie Jurassic Park released?");
Console.WriteLine($"Year: {result}");

int numberInRange = AskFroNumberInRange("Enter the number between 10 and 50:", 10, 50);

Console.WriteLine(numberInRange);

int AskForNumber(string text)
{
    Console.Write($"{text} ");
    int returnNumber = Convert.ToInt32(Console.ReadLine());
    return returnNumber;
}

int AskFroNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);
        if (number < min)
            Console.WriteLine($"{number} is too low");
        else if (number > max)
            Console.WriteLine($"{number} is too high");
        else if (number >= min && number <= max)
            return number;
    }
}