const int lowerBound = 1;
int upperBound;
string? userInput;

while (true)
{
    Console.Write("Hello, Please enter the upper bound of the sum: ");

    userInput = Console.ReadLine()?.Trim();

    if (!int.TryParse(userInput, out upperBound) || upperBound < lowerBound)
        Console.WriteLine("Invalid upper bound");
    else
        break;
}

while (true)
{
    Console.Write($"Are you sure you want to get the sum of numbers from {lowerBound} through {upperBound}? [y/n] ");

    userInput = Console.ReadLine()?.Trim().ToLower();

    if (userInput == "n")
        return;

    if (userInput != "y")
        Console.WriteLine("Invalid input");
    else
        break;
}

checked
{
    try
    {
        // O(1)
        int numberOfTerms = upperBound - lowerBound + 1;
        int seriesSum = numberOfTerms * (upperBound + lowerBound) / 2;

        // O(n)
        int loopSum = 0;

        for (int i = lowerBound; i <= upperBound; ++i)
            loopSum += i;


        Console.WriteLine($"The sum of numbers from {lowerBound} through {upperBound} = {seriesSum} (using series form)");

        Console.WriteLine($"The sum of numbers from {lowerBound} to {upperBound} = {loopSum} (using loop form)");
    }
    catch (OverflowException)
    {
        Console.Error.WriteLine("The sum exceeds the maximum value for an integer.");
    } 
}