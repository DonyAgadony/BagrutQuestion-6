class Program
{
    public static int Total(int[] arr, int numSeconds)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < numSeconds)
            {
                sum += numSeconds / arr[i];
            }
        }
        return sum;
    }

    public static int MinTime(int[] arr, int amount)
    {
        int count = 0;
        for (int i = 1; i < int.MaxValue; i++)
        {
            count = Total(arr, i);
            if (count >= amount)
            {
                return i;
            }
        }
        return 0;
    }
    public static void Main()
    {
        int[] arr = [1, 9, 3];
        Console.WriteLine(MinTime(arr, 7));
    }
}