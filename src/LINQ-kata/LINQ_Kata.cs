using System.Linq;

public class LINQ_Kata
{
	public static int Sum(int[] integers)
	{
		return integers.Sum(i => i);
	}

	public static int CountChar(char[] chars, char charToCount)
	{
		return chars.Count(c => c == charToCount);
	}

	public static int[] CalculateSquares(int start, int end)
	{
		var list = Enumerable.Range(start, end);
		var result = list.Select(i => i * i);
		return result.ToArray();
	}

	public static int SquareDigits(int n)
	{
		string digits = n.ToString();
		var result = digits.Select(Pow).Aggregate((x, y) => x + y);
		return int.Parse(result);
	}

	private static string Pow(char character)
	{
		var number = char.GetNumericValue(character);
		var square = number * number;
		return square.ToString();
	}

	public static string Replace(string s)
	{
		var chars = s.Select(ReplaceVowels).ToArray();
		return new string(chars);
	}

	private static char ReplaceVowels(char c)
	{
		return "aeiouAEIOU".Contains(c) ? '!' : c;
	}
}