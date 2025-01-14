Console.WriteLine("Enter the number of provinces you have: ");
int provinceCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of duchies you have: ");
int duchyCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of estates you have: ");
int estateCount = Convert.ToInt32(Console.ReadLine());

int totalPoints = provinceCount * 6 + duchyCount * 3 + estateCount;
Console.WriteLine("You got a total score of " + totalPoints + " points");