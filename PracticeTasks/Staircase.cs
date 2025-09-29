namespace PracticeTasks;

public class Staircase
{
	public static int CountWays(int n)
	{
		if (n <= 0) return 0;
		if (n == 1) return 1;
		if (n == 2) return 2;

		int a = 1; // Ways(1)
		int b = 2; // Ways(2)

		for (int i = 3; i <= n; i++)
		{
			int temp = a + b;
			a = b;
			b = temp;
		}

		return b;
	}
}