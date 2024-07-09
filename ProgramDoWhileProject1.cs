/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Write an integer between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (int.TryParse(readResult, out int readInt))
    {
        if (readInt >= 5 && readInt <= 10)
        {
            validEntry = true;
            Console.WriteLine($"Your input value ({readInt}) has been accepted.");
        }
        else
        {
            Console.WriteLine($"Sorry, you entered an invalid number. Please try again.");
            Console.WriteLine($"You entered {readInt}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
} while (!validEntry);

*/