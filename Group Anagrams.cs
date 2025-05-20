/*
  Time complexity: O(n*k) where n is the number os strings and k is the average length of the string
  Space complexity: O(n*k)

  Code ran successfully on Leetcode: Yes

  Approach: The hash code is computed by assigning a prime number to each lower code alphabets and then multiplying the individual characters in the string. Dictionary is used to find and group the anagrams in constant time. 

*/


public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if(strs.Length==0)
            return new List<IList<string>>();

        Dictionary<BigInteger, List<string>> dict= new();

        foreach(string str in strs)
        {
            BigInteger hashCode = GetHashCode(str);
            if(!dict.ContainsKey(hashCode))
            {
                dict.Add(hashCode, new List<string>());
            }
            dict[hashCode].Add(str);
        }
        return new List<IList<string>>(dict.Values);
    }


    private BigInteger GetHashCode(String s){

        int[] primes = {2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,67,71,73,79,83,89,97,101,103};

        BigInteger mult = 1;

        for(int i = 0; i < s.Length; i++){

            char c = s[i];

            mult = mult*(primes[c - 'a']);

        }

        return mult;

    }
}
