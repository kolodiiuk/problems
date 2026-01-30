public class Solution {
    private string complWord = "";
    private int shortestLength = int.MaxValue;
    private Dictionary<char, int> charCount = new Dictionary<char, int>();

    public string ShortestCompletingWord(string licensePlate, string[] words) {
        foreach (char c in licensePlate.ToLower()) {
            if (char.IsLetter(c)) {
                if (charCount.ContainsKey(c)) {
                    charCount[c]++;
                } else {
                    charCount[c] = 1;
                }
            }
        }

        foreach (string word in words) {
            if (word.Length < shortestLength && IsSatisfied(word)) {
                complWord = word;
                shortestLength = word.Length;
            }
        }

        return complWord;
    }

    private bool IsSatisfied(string word) {
        var count = new Dictionary<char, int>();

        foreach (char c in word) {
            if (count.ContainsKey(c)) {
                count[c]++;
            } else {
                count[c] = 1;
            }
        }

        foreach (var kvp in charCount) {
            if (!count.ContainsKey(kvp.Key) || count[kvp.Key] < kvp.Value) {
                return false;
            }
        }

        return true;
    }
}
