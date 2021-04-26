using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Programmers_2
	{
        /***
         * LV1
         * 프로그래머스 월간 코드 챌린지 시즌 1
         * 두개 뽑아서 더하기
         * https://programmers.co.kr/learn/courses/30/lessons/68644
         */

        public int[] solution(int[] numbers)
        {
            int[] answer = new int[] { };
            List<int> result = new List<int>();
            int dummy = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    dummy = numbers[i] + numbers[j];
                    result.Add(dummy);
                }
                result = result.Distinct().ToList();
            }
            answer = new int[result.Count];
            answer = result.ToArray();
            Array.Sort(answer);
            return answer;
        }
    }
}
