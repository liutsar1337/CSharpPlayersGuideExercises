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

string itemName;
int itemPrice;

switch (itemNumber)
{
    case 1:
        itemName = "Rope";
        break;
    case 2:
        itemName = "Torches";
        break;
    case 3:
        itemName = "Climbing Equipment";
        break;
    case 4:
        itemName = "Clean Water";
        break;
    case 5:
        itemName = "Machete";
        break;
    case 6:
        itemName = "Canoe";
        break;
    case 7:
        itemName = "Food Supplies";
        break;
    default:
        itemName = null;
        break;
}

switch (itemName)
{
    case "Rope":
        itemPrice = 10;
        break;
    case "Torches":
        itemPrice = 15;
        break;
    case "Climbing Equipment":
        itemPrice = 25;
        break;
    case "Clean Water":
        itemPrice = 1;
        break;
    case "Machete":
        itemPrice = 20;
        break;
    case "Canoe":
        itemPrice = 200;
        break;
    case "Food Supplies":
        itemPrice = 1;
        break;
    default:
        itemPrice = 0;
        break;
}

if (itemName != null && itemPrice > 0)
{
    Console.WriteLine($"{itemName} costs {itemPrice}");
}
else
{
    Console.WriteLine("I don't have this item");
}