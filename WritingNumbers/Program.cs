const int lowerBound = 1;

var upperBound = GetUpperBound(lowerBound);

//(TimeSpan oldApproachTime, string oldApproachResult) = WriteNumbers.WriteNumbersUsingOldApproach(lowerBound, maximumNumber);

//Console.WriteLine(oldApproachResult);
//Console.WriteLine($"Old approach, Elapsed Seconds = {oldApproachTime.TotalSeconds}");


var (newApproachTime, newApproachResult) = WriteNumbers.WriteNumbersUsingNewApproach(lowerBound, upperBound.Value);

Console.WriteLine(newApproachResult);
Console.WriteLine($"New approach, Elapsed Seconds = {newApproachTime.TotalSeconds}");


int GetUpperBound(int lowerBound)
{
    while (true)
    {
        Console.Write("Hello, Please enter the upper bound you want to write through: ");

        var input = Console.ReadLine()?.Trim();

        if (int.TryParse(input, out int upperBound) && upperBound >= lowerBound)
            return upperBound;

        Console.WriteLine("Invalid upper bound");
    }
}