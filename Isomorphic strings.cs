/*
  Time Complexity: O(n)
  Space Complexity: O(n)

  Code ran successfully on Leetcode: Yes

  Approach: A dictionary is maintained to check if each occurrence of a character in s is replaced with the same letter in t. A hashSet ensures no two alphabets are mapped to the same character.

*/

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char,char> dict = new();
        HashSet<char> hs = new();
        if(s.Length!=t.Length)
            return false;

        int index = 0;

        while(index<s.Length)
        {
            if(!dict.ContainsKey(s[index]))
            {
                if(!hs.Contains(t[index]))
                {
                    dict.Add(s[index], t[index]);
                    hs.Add(t[index]);
                }
                else
                    return false;
            }
            else
            {
                if(dict[s[index]]!=t[index])
                    return false;
            }
            index++;
        }

        return true;
    }
}
