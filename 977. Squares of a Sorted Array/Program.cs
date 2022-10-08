namespace _977._Squares_of_a_Sorted_Array;

internal class Program
{
    static void Main(string[] args)
    {
        int[] res = new Solution().SortedSquares(new int[] { -4, -1, 2, 3 });
        Console.WriteLine(String.Join(" ", res));
    }
}