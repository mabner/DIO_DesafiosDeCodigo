using System;
using System.Text.RegularExpressions;

public class ElementoMajoritario
{
	public static void Main(String[] args)
	{
		int n = int.Parse(Console.ReadLine());

		int[] num = new int[n];

		for (int i = 0; i < n; i++)
		{
			num[i] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine(MajorityElement(num));

	}
	public static int MajorityElement(int[] nums)
	{
		int major = 0;
		int count = 0;
		foreach (int v in nums)
		{
			if (major != v)
			{
				major = v;
				count = 0;
			}
			else
			{
				if (major == v)
				{
					count++;
				}
				else
				{
					count--;
				}
			}
		}
		return major;
	}
}
