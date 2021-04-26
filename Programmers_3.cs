using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Programmers_3
	{
		/***
		 * LV1
		 * 
		 * Programmers Getdayname
		 * https://programmers.co.kr/learn/courses/30/lessons/12901
		 */
		public string solution(int month, int day)
		{
			string answer = "";
			string[] strDay = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
			int[] monthDay = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			int dayCount = 0;
			int totDay = 0;
			//added before month
			for (int i = 1; i < month; i++)
			{
				dayCount += monthDay[i - 1];
			}
			//added this month
			dayCount += (day - 1);
			//added Friday(2016)
			dayCount = (dayCount + 5) % 7;
			answer = strDay[dayCount];

			//new way
			//DateTime dt = new DateTime(2016, month, day);
			//answer = dt.ToString("ddd").ToUpper();

			return answer;
		}
	}
}
