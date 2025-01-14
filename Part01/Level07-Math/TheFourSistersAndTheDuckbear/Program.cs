Console.WriteLine("Chocolate eggs gathered today: ");
int chocolateEggsCount = Convert.ToInt32(Console.ReadLine());

int forEachSister = chocolateEggsCount / 4;
int leftoverForDuckbear = chocolateEggsCount % 4;

Console.WriteLine("Each sister gets " + forEachSister);
Console.WriteLine("The duckbear gets " + leftoverForDuckbear);