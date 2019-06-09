using System;
using System.Collections;
using System.Text;

namespace Bigman.LeetCodeSolution
{
    public class ZigzagConversion
    {
        public string RunOne(string source, int nums)
        {
            StringBuilder sb = new StringBuilder();
            int cycle = 2 * (nums - 1);
            if (nums == 1)
                cycle = 1;

            for (int i = 0; i < source.Length; i += cycle)
            {
                sb.Append(source[i]);
            }

            if (nums > 2)

                for (int rowNo = 2; rowNo < nums; rowNo++)
                {
                    int a = rowNo - 1;
                    int b = cycle - rowNo + 1;
                    for (int i = 0; i + a < source.Length; i += cycle) 
                    {
                        sb.Append(source[i + a]);
                        if (i + b < source.Length)
                            sb.Append(source[i + b]);
                    }
                }


            if (nums > 1)
                for (int i = nums - 1; i < source.Length; i += cycle)
                {
                    sb.Append(source[i]);
                }
            return sb.ToString();
        }
    }
}