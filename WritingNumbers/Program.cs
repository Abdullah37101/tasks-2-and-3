const int lowerBound = 1;
int upperBound;
string? userInput;

while (true)
{
    Console.Write("Hello, Please enter the maximum number you want to write through: ");

    userInput = Console.ReadLine()?.Trim();

    if (!int.TryParse(userInput, out upperBound) || upperBound < lowerBound)
        Console.WriteLine("Invalid upper bound");
    else
        break;
}


//(TimeSpan oldApproachTime, string oldApproachResult) = WriteNumbers.WriteNumbersUsingOldApproach(lowerBound, maximumNumber);

//Console.WriteLine(oldApproachResult);
//Console.WriteLine($"Old approach, Elapsed Seconds = {oldApproachTime.TotalSeconds}");


(TimeSpan newApproachTime, string newApproachResult) = WriteNumbers.WriteNumbersUsingNewApproach(lowerBound, upperBound);

Console.WriteLine(newApproachResult);
Console.WriteLine($"New approach, Elapsed Seconds = {newApproachTime.TotalSeconds}");