using NUnit.Framework;
using System.IO;

[TestFixture]
public class LINQ_KataTest
{
	[Test]
	public void SumOfArrayTest()
	{
		Assert.AreEqual(6, LINQ_Kata.Sum(new[] { 2, 3, 1 }));
	}

	[Test]
	public void CountOccurencesOfCharacterTest()
	{
		Assert.AreEqual(2, LINQ_Kata.CountChar(new[] { 'A', 'B', 'C', 'A' }, 'A'));
	}

	[Test]
	public void CalculateSquaresTest()
	{
		Assert.AreEqual(new[] { 1, 4, 9, 16, 25, 36 }, LINQ_Kata.CalculateSquares(1, 6));
	}

	[TestCase("for")]
	[TestCase("while")]
	public void FindWord(string input)
	{
		//the path of the file
		FileStream inFile = new FileStream(@"..\..\LINQ_Kata.cs", FileMode.Open, FileAccess.Read);
		StreamReader reader = new StreamReader(inFile);
		string record;
		try
		{
			//the program reads the record and displays it on the screen
			record = reader.ReadLine();
			while (record != null)
			{
				if (record.Contains(input))
				{
					Assert.Fail(input + " found");
				}
				record = reader.ReadLine();
			}
			Assert.IsTrue(true);
		}
		finally
		{
			//after the record is done being read, the progam closes
			reader.Close();
			inFile.Close();
		}
	}
}