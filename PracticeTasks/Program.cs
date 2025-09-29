namespace PracticeTasks;

internal class Program
{
	static void Main(string[] args)
    {
		// 1. PalindromeChecker tests

		Console.WriteLine("1. PalindromeChecker tests"); 

		Console.WriteLine(PalindromeChecker.sPalindrome("aba"));        // True
		Console.WriteLine(PalindromeChecker.sPalindrome("hello"));      // False
		Console.WriteLine(PalindromeChecker.sPalindrome("A man a plan a canal Panama")); // True


		// 2. CoinCalculator tests

		Console.WriteLine("\n2. CoinCalculator tests");
		Console.WriteLine(CoinCalculator.MinSplit(87)); // 4 (1x50 + 1x20 + 1x10 + 1x5 + 2x1)
		Console.WriteLine(CoinCalculator.MinSplit(3));  // 3 (3x1)

		// 3. ArrayTasks tests
		Console.WriteLine("\n3. ArrayTasks tests");
		Console.WriteLine(ArrayTasks.NotContains(new int[] { 1, 3, 6, 4, 1, 2 })); // 5
		Console.WriteLine(ArrayTasks.NotContains(new int[] { 1, 2, 3 })); // 4
		Console.WriteLine(ArrayTasks.NotContains(new int[] { 3, 4, -1, 1 })); // 2
		Console.WriteLine(ArrayTasks.NotContains (new int[] { 7, 8, 9, 11, 12 })); // 1

		// 4. BracketChecker tests
		Console.WriteLine("\n4. BracketChecker tests");
		Console.WriteLine(BracketChecker.IsProperly("()")); // True
		Console.WriteLine(BracketChecker.IsProperly("(()())")); // True
		Console.WriteLine(BracketChecker.IsProperly("())()"));  // False
		Console.WriteLine(BracketChecker.IsProperly("((()))")); // True
		Console.WriteLine(BracketChecker.IsProperly("(()"));    // False

		// 5. Staircase tests
		Console.WriteLine("\n5. Staircase tests");
		Console.WriteLine(Staircase.CountWays(2)); // 2
		Console.WriteLine(Staircase.CountWays(3)); // 3
		Console.WriteLine(Staircase.CountWays(4)); // 5
		Console.WriteLine(Staircase.CountWays(5)); // 8
	}
}
