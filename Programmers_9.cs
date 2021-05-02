using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /**
     * LV2
     * 프로그래머스
     * 스킬트리
     * https://programmers.co.kr/learn/courses/30/lessons/49993#
     */
    class Programmers_9
	{
        public int solution(string skill, string[] skill_trees)
        {
            int answer = 0;
            for (int i = 0; i < skill_trees.Length; i++)
            {
                bool isCorrect = true;
                //degree count
                int count = 0;
                //string length
                for (int j = 0; j < skill_trees[i].Length; j++)
                {
                    //skill 내부의 인덱스와 skilltrees 내부의 인덱스 비교
                    //ex)  cbd 와 bacde 비교, b는 skill의 1번째이므로 false
                    //틀릴경우 = 순서 맞지 않음
                    if (count < skill.IndexOf(skill_trees[i][j]))
                    {
                        isCorrect = false;
                        break;
                    }
                    //차수와 인덱스 같을 경우 다음 순서 탐색
                    else if (count == skill.IndexOf(skill_trees[i][j]))
                    {
                        count++;
                    }
                    //else는 순서에 포함되어있지 않으므로 continue
                }
                if (isCorrect)
                    answer++;
            }
            return answer;
        }
    }
}
