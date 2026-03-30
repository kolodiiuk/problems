public class Solution 
{
    public bool WordPattern(string pattern, string s) 
    {
        var map = new Dictionary<char, string>();
        var splitted = s.Split(" ");
        if (pattern.Length != splitted.Length)
        {
            return false;
        }
        
        for (int patternIdx = 0, splittedIdx = 0; 
            patternIdx < pattern.Length && splittedIdx < splitted.Length; 
            ++patternIdx, ++splittedIdx) 
        {
            if (map.TryGetValue(pattern[patternIdx], out _))
            {
                if (map[pattern[patternIdx]] != splitted[splittedIdx])
                {
                    return false;
                }
            }
            else
            {
                if (map.ContainsValue(splitted[splittedIdx]))
                {
                    return false;
                }

                map.Add(pattern[patternIdx], splitted[splittedIdx]);
            }
        }

        return true;
    }
}
