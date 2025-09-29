namespace PracticeTasks;

public class ArrayTasks
{
	public static int NotContains(int[] numbers)
	{
		if (numbers == null || numbers.Length == 0)
			return 1;

		HashSet<int> set = new HashSet<int>(numbers.Where(n => n > 0));

		int smallest = 1;
		while (set.Contains(smallest))
		{
			smallest++;
		}

		return smallest;
	}
}