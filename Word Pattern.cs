/*
  Time complexity: O(n*k) where n is the number of words and k is the average length of each word
  Space complexity: O(n*k)

  Code ran successfully on Leetcode: Yes

  Approach: The approach remains same as the logic used for Isomorphic strings except the fact that each character is mapped to a string instead of a character.
*/

public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] array = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Dictionary<char,string> dict = new();
        HashSet<string> hs = new();

        if(array.Length!=pattern.Length)
            return false;

        int index = 0;

        while(index<pattern.Length)
        {
            if(!dict.ContainsKey(pattern[index]))
            {
                if(!hs.Contains(array[index]))
                {
                    dict.Add(pattern[index],array[index]);
                    hs.Add(array[index]);
                }
                else
                    return false;
            }
            else
            {
                if(dict[pattern[index]]!=array[index])
                    return false;
            }
            index++;
        }
        return true;
    }
}
