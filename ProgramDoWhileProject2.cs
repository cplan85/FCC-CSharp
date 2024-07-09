/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    readResult = Console.ReadLine();
    string formattedResult = "";
    if (readResult != null) {
        formattedResult = readResult.Trim().ToLower();
    }
    
    if (formattedResult == "administrator" ||  formattedResult == "manager" ||  formattedResult == "user")
    {
    
            validEntry = true;
            Console.WriteLine($"Your input value ({readResult}) has been accepted.");
    
     
    }
    else
    {
        Console.WriteLine($"The role name that you entered, ({readResult}) is not valid.");
    }
} while (!validEntry);

*/