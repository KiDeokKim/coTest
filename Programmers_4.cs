using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Programmers_4
	{
		/***
		 * LV1
		 * Programmers
		 * 3개의 값 더해서 소수 구하기
		 * https://programmers.co.kr/learn/courses/30/lessons/12977
		 */
		public int solution(int[] nums)
		{
			int count = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					for (int k = j + 1; k < nums.Length; k++)
					{
						int dummy = nums[i] + nums[j] + nums[k];
						bool notPrimeNum = false;
						for (int l = 2; l < dummy; l++)
						{
							if (dummy % l == 0)
							{
								notPrimeNum = true;
								break;
							}
						}
						if (!notPrimeNum)
						{
							count += 1;
						}
					}
				}
			}

			return count;
		}
	}
}
