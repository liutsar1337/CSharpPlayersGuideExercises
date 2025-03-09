Countdown(10);

void Countdown(int number)
{
    Console.WriteLine(number);
    if (number == 1) return;
    Countdown(number - 1);
}