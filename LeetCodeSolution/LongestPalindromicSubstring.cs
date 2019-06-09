using System;
using System.Collections;

namespace Bigman.LeetCodeSolution
{
    public class LongestPalindromicSubstring
    {
        public string RunOne(string source)
        {
            string longestPalindromicSubstring="";

            for(int i=0; i< source.Length; i++)
            {
                for(int j=i+longestPalindromicSubstring.Length; j< source.Length; j++){
                    if ( IsPalindromic(source,i,j) && j-i+1>longestPalindromicSubstring.Length){
                        longestPalindromicSubstring = source.Substring(i,j-i+1);
                    }
                }
            }

            return longestPalindromicSubstring;
        }

        public bool IsPalindromic(string source, int startIndex, int endIndex)
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
    }
}