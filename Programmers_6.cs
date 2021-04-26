using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /**
	 * LV2
	 * Programmers 
	 * 올바른 괄호 구하기
	 * https://programmers.co.kr/learn/courses/30/lessons/12909
	 * "()()"	true
     * "(())()"	true
     * ")()("	false
     * "(()("	false
	 */
    class Programmers_6
	{
        public bool solution(string s)
        {
            bool answer = true;
            int strLen = s.Length;
            char[] strChr = s.ToCharArray();
            int count = 0;
            for (int i = 0; i < strLen; i++)
            {
                if (strChr[0] != '(')
                {
                    count = -1;
                    break;
                }
                else
                {
                    if (strChr[i] == '(')
                        count += 1;
                    else
                    {
                        if (count <= 0)
                        {
                            count = -1;
                            break;
                        }
                        else
                            count -= 1;
                    }

                }
            }
            if (count == 0)
                answer = true;
            else
                answer = false;
            return answer;
        }
    }
}
