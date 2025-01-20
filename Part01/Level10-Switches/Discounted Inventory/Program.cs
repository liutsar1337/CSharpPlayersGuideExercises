Console.WriteLine("The following items are available:");
Console.WriteLine("1 – Rope");
Console.WriteLine("2 – Torches");
Console.WriteLine("3 – Climbing Equipment");
Console.WriteLine("4 – Clean Water");
Console.WriteLine("5 – Machete");
Console.WriteLine("6 – Canoe");
Console.WriteLine("7 – Food Supplies");
Console.Write("What number do you want to see the price of? ");

var valueChar = Console.ReadKey().KeyChar.ToString();
int itemNumber = Convert.ToInt32(valueChar);


Console.WriteLine();

string itemName = itemNumber switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => ""
};
int itemPrice = itemName switch
{
    "Rope" => 10,
    "Torches" => 16,
    "Climbing Equipment" => 24,
    "Clean Water" => 2,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 2,
    _ => 0
};


if (itemName != "" && itemPrice > 0)
{
    string discountName = "Liu";
    Console.Write("\nWhat is your name? ");
    string userName = Console.ReadLine();
    
    bool applyDiscount = discountName == userName;
    if (applyDiscount) itemPrice /= 2;
    Console.WriteLine($"{itemName} costs {itemPrice}");
}
else
{
    Console.WriteLine("I don't have this item");
}