namespace PracticeTasks;

public class PalindromeChecker
{
	public static bool sPalindrome(string text)
	{
		if (string.IsNullOrEmpty(text))
			return false;

		string cleaned = new string(text
			.Where(char.IsLetterOrDigit)
			.Select(char.ToLower)
			.ToArray());

		string reversed = new string(cleaned.Reverse().ToArray());
		return cleaned == reversed;
	}
}