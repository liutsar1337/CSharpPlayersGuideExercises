Console.Write("Enter the number that flows to the clock: ");
int clockNumber = Convert.ToInt32(Console.ReadLine());

if (clockNumber % 2 == 0) Console.WriteLine("Tick");
else Console.WriteLine("Tock");