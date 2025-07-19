using System.Diagnostics;

public static class AddNumbers
{
    // O(1)
    public static (TimeSpan timeTaken, int sum) AddNumbersUsingSeries(int lowerBound, int upperBound)
    {
        if (lowerBound > upperBound)
            throw new ArgumentException("Lower bound must be less than or equal to upper bound.");

        Stopwatch stopwatch = Stopwatch.StartNew();

        int numberOfTerms = upperBound - lowerBound + 1;
        int sum = numberOfTerms * (upperBound + lowerBound) / 2;

        stopwatch.Stop();

        return (stopwatch.Elapsed, sum);
    }

    public static (TimeSpan timeTaken, int sum) AddNumbersUsingLoop(int lowerBound, int upperBound)
    {
        if (lowerBound > upperBound)
            throw new ArgumentException("Lower bound must be less than or equal to upper bound.");

        Stopwatch stopwatch = Stopwatch.StartNew();

        int sum = 0;
        for (int i = lowerBound; i <= upperBound; ++i)
            sum += i;

        stopwatch.Stop();

        return (stopwatch.Elapsed, sum);
    }
}

