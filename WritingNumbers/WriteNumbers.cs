using System.Diagnostics;
using System.Text;

public static class WriteNumbers
{
    // O(n^2)
    public static (TimeSpan timeTaken, string result) WriteNumbersUsingOldApproach(int lowerBound, int upperBound)
    {
        if (upperBound < lowerBound)
            throw new ArgumentException("Invalid range specified");

        Stopwatch stopwatch = Stopwatch.StartNew();
        string result = string.Empty;

        for (int i = lowerBound; i <= upperBound; ++i)
        {
            result += i;

            if (i < upperBound)
                result += ", ";
        }

        stopwatch.Stop();

        return (stopwatch.Elapsed, result);
    }

    // O(n)
    public static (TimeSpan timeTaken, string result) WriteNumbersUsingNewApproach(int lowerBound, int upperBound)
    {
        if (upperBound < lowerBound)
            throw new ArgumentException("Invalid range");

        Stopwatch stopwatch = Stopwatch.StartNew();
        StringBuilder result = new();

        for (int i = lowerBound; i <= upperBound; ++i)
        {
            result.Append(i);

            if (i < upperBound)
                result.Append($", ");
        }

        return (stopwatch.Elapsed, result.ToString());
    }
}