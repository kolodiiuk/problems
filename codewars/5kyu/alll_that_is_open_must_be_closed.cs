using System.Collections.Generic;

public class Kata
{
    private record struct CharIsMatching(char Char, bool IsMatching);

    public static bool IsBalanced(string s, string caps)
    {
        var dict = new Dictionary<CharIsMatching, char>();
        for (int o = 0, c = 1; c < caps.Length; o += 2, c += 2)
        {
            if (caps[o] == caps[c])
            {
                dict.Add(new CharIsMatching(caps[o], true), caps[c]);
            }
            else
            {
                dict.Add(new CharIsMatching(caps[o], false), caps[c]);
            }
        }

        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; ++i)
        {
            if (dict.ContainsKey(new CharIsMatching(s[i], false)))
            {
                stack.Push(s[i]);
            }
            else if (dict.ContainsKey(new CharIsMatching(s[i], true)))
            {
                stack.TryPeek(out var peeked);
                if (s[i] == peeked)
                {
                    stack.TryPop(out var cap);
                    if (dict.TryGetValue(new CharIsMatching(cap, true), out var c) && c != s[i]
                        || dict.TryGetValue(new CharIsMatching(cap, false), out var c1) && c1 != s[i])
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(s[i]);
                }
            }
            else if (dict.ContainsValue(s[i]))
            {
                var res = stack.TryPop(out var cap);
                if (!res || dict.TryGetValue(new CharIsMatching(cap, true), out var c) && c != s[i]
                    || dict.TryGetValue(new CharIsMatching(cap, false), out var c1) && c1 != s[i])
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
