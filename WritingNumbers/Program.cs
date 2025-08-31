using System.Diagnostics;

const int lowerBound = 1;

var upperBound = GetUpperBound(lowerBound);

Stopwatch stopwatch = Stopwatch.StartNew();

var oldApproachResult = WriteNumbers.WriteNumbersUsingOldApproach(lowerBound, upperBound);

Console.WriteLine(oldApproachResult);
Console.WriteLine($"Old approach, Elapsed Seconds = {stopwatch.Elapsed.TotalSeconds}");

stopwatch.Restart();

var newApproachResult = WriteNumbers.WriteNumbersUsingNewApproach(lowerBound, upperBound);

stopwatch.Stop();

Console.WriteLine(newApproachResult);
Console.WriteLine($"New approach, Elapsed Seconds = {stopwatch.Elapsed.TotalSeconds}");


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