namespace PracticeTasks;

public class CoinCalculator
{
	public static int MinSplit(int amount)
	{
		int[] coins = { 50, 20, 10, 5, 1 };
		int count = 0;

		foreach (int coin in coins)
		{
			if (amount == 0)
				break;

			count += amount / coin; 
			amount %= coin;         
		}

		return count;
	}
}