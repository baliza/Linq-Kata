using System;

public class LINQ_Kata
{
    public static int Sum(int[] integers)
    {
        var sum = 0;
        foreach (var i in integers)
        {
            sum += i;
        }
        return sum;
    }

    public static int CountChar(char[] chars, char charToCount)
    {
        var occurences = 0;
        foreach (var c in chars)
        {
            if (c == charToCount)
                occurences++;
        }
        return occurences;
    }

    public static int[] CalculateSquares(int start, int end)
    {
        var result = new int[end - start + 1];
        for (var i = start; i <= end; i++)
        {
            result[i - start] = i * i;
        }
        return result;
    }
}