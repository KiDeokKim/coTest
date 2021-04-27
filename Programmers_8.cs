using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	/**
	 * Lv2
	 * Programmers 
	 * get remainder value of fibonacci to 1234567
	 * 
	 */
	class Programmers_8_cs
	{
		#region new Solution
		public int solution(int n)
		{
			int val = 1234567;
			int[] arr = new int[n + 1];
			arr[0] = 0;
			arr[1] = 1;
			// (a+b)%c = (a%c + b%c)%c _Modular arithmetic
			for (int i = 2; i < n + 1; i++)
			{
				arr[i] = ((arr[i - 2] % val) + (arr[i - 1] % val)) % val;
			}

			return arr[n];
		}
		#endregion

		#region Before solution
		/*
		public int solution(int n)
		{
			int val = 1234567;

			return getFibonacci(n) % val;
		}

		public int getFibonacci(int i)
		{
			if (i < 2)
			{
				if (i == 1)
					return 1;
				else
					return 0;
			}
			else
			{
				return (getFibonacci(i - 2) + getFibonacci(i - 1));
			}
		}
		*/
		#endregion
	}
}
