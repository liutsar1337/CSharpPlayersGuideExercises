int[] array = new int[] { 51, 24, 100, 12, 355 };

int minimum = int.MaxValue;
foreach (int value in array)
{
    if (value < minimum)
        minimum = value;
}

int total = 0;
foreach (int value in array)
{
    total += value;
}

float average = (float)total / array.Length;

Console.WriteLine($"Array's minimum is {minimum} and average is {average}");