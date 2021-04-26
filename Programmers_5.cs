using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	/***
	 * Programmers
	 * LV1 
	 * 음/양 더하기
	 * https://programmers.co.kr/learn/courses/30/lessons/76501
	 * 
	 */
	class Programmers_5
	{
		public int solution(int[] absolutes, bool[] signs)
		{
			int answer = 0;

			for (int i = 0; i < signs.Length; i++)
			{
				if (!signs[i])
				{
					absolutes[i] *= -1;
				}
				answer += absolutes[i];
			}

			return answer;
		}
	}
}
