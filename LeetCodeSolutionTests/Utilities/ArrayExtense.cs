using System.Collections;

namespace Bigman.LeetCodeSolutionTests.Utilities
{
    public class ArrayExtense
    {
        public bool SameArray(int[] source, int[] target){
            if(source.Length==target.Length){
                for(int i = 0; i < source.Length; i++){
                    if(source[i]!=target[i]){
                        return false;
                    }
                }
                return true;
            }
            else{
                return false;
            }
        }
    }
}