using System;
namespace Bigman.LeetCodeSolution
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int RunOne(string s)
        {
            int res = 0;
            string tmp = "";
            for(int i=0; i<s.Length; i++){
                if(tmp.Contains(s[i])){
                    tmp = tmp.Substring(tmp.IndexOf(s[i])+1);
                }
                tmp = $"{tmp}{ s[i]}";

                if(tmp.Length > res){
                    res = tmp.Length;
                }
            }
            return res;
        }
    }
}