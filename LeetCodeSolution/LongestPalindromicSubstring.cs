using System;
using System.Collections;

namespace Bigman.LeetCodeSolution
{
    public class LongestPalindromicSubstring
    {
        public string RunOne(string source)
        {
            string longestPalindromicSubstring = "";

            for (int i = 0; i < source.Length; i++)
            {
                for (int j = i + longestPalindromicSubstring.Length; j < source.Length; j++)
                {
                    if (IsPalindromic(source, i, j) && j - i + 1 > longestPalindromicSubstring.Length)
                    {
                        longestPalindromicSubstring = source.Substring(i, j - i + 1);
                    }
                }
            }

            return longestPalindromicSubstring;
        }

        private bool IsPalindromic(string source, int startIndex, int endIndex)
        {
            for (int i = 0; i < endIndex - startIndex; i++)
            {
                if (source[startIndex + i] != source[endIndex - i])
                {
                    return false;
                }
            }
            return true;
        }


        public string RunTwo(string source)
        {
            string longestPalindromicSubstring = "";

            for (int i = 0; i < source.Length; i++)
            {
                var tmp = GetLongetsPalindromicString( source, i);
                if(tmp.Length>longestPalindromicSubstring.Length)
                {
                    longestPalindromicSubstring = tmp;
                }
            }

            return longestPalindromicSubstring;
        }

        private string GetLongetsPalindromicString(string source, int index)
        {
            int startIndex=0, endIndex=0;
            string tmp = "";
            for (int i = 0; i <= index && index - i >= 0 && index + i < source.Length; i++)
            {

                if (source[index - i] == source[index + i])
                {
                    startIndex = index - i;
                    endIndex = index + i;
                }
                else
                {
                    break;
                }
            }
            tmp = source.Substring(startIndex, endIndex - startIndex + 1);

            if (index + 1 < source.Length && source[index] == source[index + 1])
            {

                for (int i = 0; i <= index && index - i >= 0 && index + i + 1 < source.Length; i++)
                {

                    if (source[index - i] == source[index + i + 1])
                    {
                        startIndex = index - i;
                        endIndex = index + i + 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (tmp.Length < endIndex - startIndex + 1)
                {

                    tmp = source.Substring(startIndex, endIndex - startIndex + 1);
                }
            }



            return tmp;
        }

    }
}