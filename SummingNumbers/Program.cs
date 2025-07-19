const int lowerBound = 1;

var upperBound = GetUpperBound(lowerBound);

if (!ConfirmSum(lowerBound, upperBound))
    return;

checked
{
    try
    {
        var (loopApproachTime, loopSum) = AddNumbers.AddNumbersUsingLoop(lowerBound, upperBound);

        var (seriesApproachTime, seriesSum) = AddNumbers.AddNumbersUsingSeries(lowerBound, upperBound);

        Console.WriteLine($"The sum of numbers from {lowerBound} to {upperBound} = {loopSum} (using loop form)\nElapsed Seconds = {loopApproachTime.TotalSeconds}");

        Console.WriteLine($"The sum of numbers from {lowerBound} through {upperBound} = {seriesSum} (using series form)\nElapsed Seconds = {seriesApproachTime.TotalSeconds}");
    }
    catch (OverflowException)
    {
        Console.Error.WriteLine("The sum exceeds the maximum value for an integer.");
    } 
}

bool ConfirmSum(int lowerBound, int upperBound)
{
    while (true)
    {
        Console.Write($"Are you sure you want to get the sum of numbers from {lowerBound} through {upperBound}? [y/n] ");
        var input = Console.ReadLine()?.Trim().ToLower();

        if (input == "n")
            return false;

        if (input == "y")
            return true;

        Console.WriteLine("Invalid input");
    }
}

int GetUpperBound(int lowerBound)
{
    while (true)
    {
        Console.Write("Hello, Please enter the upper bound of the sum: ");

        var userInput = Console.ReadLine()?.Trim();

        if (!int.TryParse(userInput, out int upperBound) || upperBound < lowerBound)
            Console.WriteLine("Invalid upper bound");
        
        return upperBound;
    }
}