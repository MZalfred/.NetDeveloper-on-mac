// C# 8.0 introduced enhanced nullability checking. 
// Let's handle a common scenario with 'Console.ReadLine()'.

string? userInput = Console.ReadLine();
if (userInput != null)
{
    // Safe to use 'userInput' as it's confirmed to be non-null
    Console.WriteLine($"You entered: {userInput}");
}
else
{
    // Handle the case where 'userInput' is null
    Console.WriteLine("No input detected.");
}
