namespace _557._Reverse_Words_in_a_String_III;

public class Solution
{
    public string ReverseWords(string s)
    {
        char[] c = s.ToCharArray();
        char temp;

        for (int i = 0; i <= (s.Length - 2) / 2; i++)
        {
            temp = c[i];
            c[i] = c[s.Length - 1 - i];
            c[c.Length - 1 - i] = temp;
        }

        string[] words = new string(c).Split(' ');
        Array.Reverse(words);

        return String.Join(" ", words);
    }
}
