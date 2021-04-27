using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Programmers_7
	{
		/**
		 * 
		 * LV2
		 * Programmers
		 * 주식가격 구하기
		 * https://programmers.co.kr/learn/courses/30/lessons/42584#
		 */

		#region Solution not using stack,Queue
		// Solved Time Complexity

		public int[] solution(int[] prices)
		{

			int length = prices.Length;
			int[] answer = new int[length];

			foreach (int i in answer)
			{
				answer[i] = 0;
			}

			return CalculatePrice(prices, answer);
		}
		public int[] CalculatePrice(int[] prices, int[] answer)
		{
			for (int i = 0; i < prices.Length; i++)
			{
				for (int j = i + 1; j < prices.Length; j++)
				{
					if (prices[i] <= prices[j])
					{
						answer[i] += 1;
					}
					else
					{
						answer[i] += 1;
						break;
					}
				}
			}
			return answer;
		}

		#endregion


		#region Solution to Stack + Queue
		/*
		// not solved Time Complexity
		public static int[] solution(int[] prices)
		{
			Stack<int> stk = new Stack<int>();
			Queue<int> answer = new Queue<int>();

			for (int i = prices.Length - 1; i >= 0; i--)
				stk.Push(prices[i]);

			while (stk.Count > 0)
			{
				int fVal = stk.Pop();
				if (stk.Count == 0)
				{
					answer.Enqueue(0);
					break;
				}
				else
				{
					if (fVal > stk.ElementAt(0))
					{
						answer.Enqueue(1);
						continue;
					}
					else
					{
						int price = 0;
						for (int i = 0; i < stk.Count; i++)
						{
							if (fVal <= stk.ElementAt(i))
								price++;
							else
							{
								price += 1;
								break;
							}
						}
						answer.Enqueue(price);
					}
				}
			}
			return answer.ToArray();
		}
		*/
		#endregion
		#region Solution using Queue
		/*
			public static int[] solution(int[] prices)
			{

				Queue<int> val = new Queue<int>();
				Queue<int> answer = new Queue<int>();
				//input prices value in queue
				for (int i = 0; i < prices.Length; i++)
				{
					val.Enqueue(prices[i]);
				}
				int len = val.Count;
				CalculatePrice(val, answer);
				return answer.ToArray();
			}

			public static void CalculatePrice(Queue<int> val, Queue<int> answer)
			{
				int count = 0;
				int fVal = val.Dequeue();
				int[] arr = val.ToArray();
				//if last value, it is zero
				if (val.Count == 0)
				{
					answer.Enqueue(0);
				}
				//after 1 sec, price down -> value is 1
				else
				{
					if (fVal > val.Peek())
					{
						answer.Enqueue(1);
						CalculatePrice(val, answer);
					}
					else
					{
						for (int i = 0; i < arr.Length; i++)
						{
							if (fVal > arr[i])
							{
								count += 1;
								break;
							}
							else
								count++;
						}
						answer.Enqueue(count);
						CalculatePrice(val, answer);
					}
				}
			}
		*/
		#endregion

	}
}
