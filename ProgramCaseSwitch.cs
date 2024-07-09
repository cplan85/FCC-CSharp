/*
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
     case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
     case "03":
        type = "Sweat pants";
        break;
     default:
     type = "Other";
     break;
} 

switch (product[1])
{
     case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
     default:
     color = "White";
     break;
} 

switch (product[2])
{
     case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
     default:
     size = "One Size Fits All";
     break;
}



Console.WriteLine($"Product: {size} {color} {type}");

*/

/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };

int total = 0;
bool found = true;

foreach (int number in numbers)
{

    total += number;

    if (number == 42)
    {
       found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
*/


/*
string permission = "Admin";
int level = 57;


string result = permission.Contains("Admin") && level > 55 ? "Welcome, Super Admin user." :
permission.Contains("Admin") && level <= 55 ? "Welcome, Admin user." :
permission.Contains("Manager") && level > 20 ? "Contact an Admin for access." :
permission.Contains("Manager") && level < 20 ? "You do not have sufficient privileges." :
"You do not have sufficient privileges.";

Console.WriteLine(result);

int value1 = 5;

if (value1 > 0)
{
    int value2 = 6;
    value1 = value1 + value2;
}

*/
