using System.Diagnostics;

public static class AddNumbers
{
    // O(1)
    public static int AddNumbersUsingSeries(int lowerBound, int upperBound)
    {
        if (lowerBound > upperBound)
            throw new ArgumentException("Lower bound must be less than or equal to upper bound.");

        int numberOfTerms = upperBound - lowerBound + 1;
        int sum = numberOfTerms * (upperBound + lowerBound) / 2;

        return sum;
    }

    public static int AddNumbersUsingLoop(int lowerBound, int upperBound)
    {
        if (lowerBound > upperBound)
            throw new ArgumentException("Lower bound must be less than or equal to upper bound.");

        int sum = 0;
        for (int i = lowerBound; i <= upperBound; ++i)
            sum += i;

        return sum;
    }
}

