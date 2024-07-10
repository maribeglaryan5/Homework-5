namespace Homework2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 6, 8, 19, 20, 23, 15, 26, 28 };
            int i = 0;
            int count = 0;
            while (i < arr.Length)
            {
                if (arr[i] < ((int[i] + int[i]) / 2))
                {
                    count++;
                }
                i++;
            }
            Console.WriteLine(count);
        }
    }
}
