using System.Diagnostics;
using System.Text;

public static class WriteNumbers
{
    // O(n^2)
    public static string WriteNumbersUsingOldApproach(int lowerBound, int upperBound)
    {
        if (upperBound < lowerBound)
            throw new ArgumentException("Invalid range specified");

        string result = string.Empty;

        for (int i = lowerBound; i <= upperBound; ++i)
        {
            result += i;

            if (i < upperBound)
                result += ", ";
        }

        return result;
    }

    // O(n)
    public static string WriteNumbersUsingNewApproach(int lowerBound, int upperBound)
    {
        if (upperBound < lowerBound)
            throw new ArgumentException("Invalid range");

        StringBuilder result = new();

        for (int i = lowerBound; i <= upperBound; ++i)
        {
            result.Append(i);

            if (i < upperBound)
                result.Append($", ");
        }

        return result.ToString();
    }
}