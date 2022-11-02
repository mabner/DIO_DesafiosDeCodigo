using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace DesafiosDeCodigo.C
{
	public class ElementoMajoritario
	{
		public static void Main(String[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int[] num = new int[n];

			for (int i = 0; i < num.lenght; i++)
			{
				num[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine(MajorityElement(num));

		}
		public static int MajorityElement(int[] nums)
		{
			int major = nums[0];
			int count = 1;
			for (                   )
			{
				if (                    )
				{
					major = nums[i];
					count;
				}
				else
				{
					if (major == nums[i])
					{
						count++;
					}
					else
					{
						count--;
					}
				}
			}
			return;
		}
	}
}