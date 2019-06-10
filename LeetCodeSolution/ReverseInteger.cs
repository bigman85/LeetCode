using System;
namespace Bigman.LeetCodeSolution
{
    public class ReverserInteger
    {
        public int RunOne(int num)
        {        
            int res = 0;
            while (num != 0)
            {
                checked
                {
                    try
                    {
                        res = res * 10 + num % 10;
                    }
                    catch (OverflowException)
                    {
                        res = 0;
                        break;
                    }
                    num = num / 10;
                }
            }

            return res;
        }
    }
}