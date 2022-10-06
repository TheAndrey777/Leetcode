using System.Reflection;

namespace _278._First_Bad_Version;

public class VersionControl
{
    readonly int version = 1;
    public bool IsBadVersion(int n)
    {
        return version <= n;
    }
}

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        long lowest = 0;
        long highest = n;

        while (highest >= lowest & n > 1)
        {
            long middle = (lowest + highest) / 2;

            if (IsBadVersion((int)(middle + 1)))
                highest = middle - 1;
            else
                lowest = middle + 1;
        }
        return (int)(lowest + 1);
    }
}
