internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Solution.LengthOfLastWord("luffy is still joyboy"));
    }
}

public class Solution
{
    public static int LengthOfLastWord(string s)
    {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return words[^1].Length;
    }
}