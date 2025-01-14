Console.WriteLine("Input triangle's base: ");
string triangleBaseText = Console.ReadLine();
double triangleBase = Convert.ToDouble(triangleBaseText);

Console.WriteLine("Input triangle's height: ");
string triangleHeightText = Console.ReadLine();
double triangleHeight = Convert.ToDouble(triangleHeightText);

double triangleArea = (triangleBase * triangleHeight) / 2;

Console.WriteLine("Triangle Area: " + triangleArea);