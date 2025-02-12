namespace ConsoleApp1;

public class Anagram
{
    public static bool IsAnagram(string str1, string str2)
    {
        str1 = str1.ToLower().Replace(" ", "");
        str2 = str2.ToLower().Replace(" ", "");

        if (str1.Length != str2.Length) return false;
        
        //--------------------------------------------------------------------------------
        // Dictionary<char, int> freq1 = new Dictionary<char, int>();
        // Dictionary<char, int> freq2 = new Dictionary<char, int>();
        //
        // foreach (char c in str1)
        // {
        //     freq1[c] = freq1.ContainsKey(c) ? freq1[c] + 1 : 1; // Efficient increment
        // }
        //
        // foreach (char c in str2)
        // {
        //     freq2[c] = freq2.ContainsKey(c) ? freq2[c] + 1 : 1;
        // }
        //
        // return freq1.SequenceEqual(freq2);
        //--------------------------------------------------------------------------------
        
        char[] str1Arr = str1.ToCharArray();
        char[] str2Arr = str2.ToCharArray();
        
        Array.Sort(str1Arr);
        Array.Sort(str2Arr);
        
        return str1Arr.SequenceEqual(str2Arr);
    }
}