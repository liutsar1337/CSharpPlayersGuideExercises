int[] original = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write($"Enter a number for index {i}: ");
    int userIndex = Convert.ToInt32(Console.ReadLine());
    original[i] = userIndex;
}

int[] replicated = new int[5];
for (int i = 0; i < 5; i++)
{
    replicated[i] = original[i];
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Value at index {i} in a1:{original[i]} and a2:{replicated[i]}");
}