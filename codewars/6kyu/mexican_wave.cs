using System.Collections.Generic;

namespace CodeWars
{
    public class Kata
    {
        public List<string> wave(string str)
        {
            if (string.IsNullOrEmpty(str))
                return new List<string>();
            var res = new List<string>();
            var index = 0;
            while (str[index] == ' ')
            {
                index++;
            }

            var len = index;
            for (int i = index; i < str.Length - 1; i++)
            {
                if (str[i] == ' ')
                {
                    len++;
                    continue;
                }

                var newStr = str.Substring(0, len++) + char.ToUpper(str[i]) + str.Substring(i + 1);
                res.Add(newStr);
            }

            if (str[str.Length - 1] != ' ')
                res.Add(str.Substring(0, str.Length - 1) + char.ToUpper(str[str.Length - 1]));

            return res;
        }
    }
}
