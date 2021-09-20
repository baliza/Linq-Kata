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

	public static int SquareDigits(int n)
	{
		string digits = n.ToString();
		string result = "";

		foreach (char character in digits)
		{
			int number = Convert.ToInt32(character.ToString());
			int square = number * number;
			result += square;
		}
		return int.Parse(result);
	}

	public static string Replace(string s)
	{
		char[] result = new char[s.Length];
		for (var i = 0; i < s.Length; i++)
		{
			if (s[i] == 'a' || s[i] == 'A' ||
				s[i] == 'e' || s[i] == 'E' ||
				s[i] == 'i' || s[i] == 'I' ||
				s[i] == 'o' || s[i] == 'O' ||
				s[i] == 'u' || s[i] == 'U')
				result[i] = '!';
			else
				result[i] = s[i];
		}
		return new string(result);
	}
}