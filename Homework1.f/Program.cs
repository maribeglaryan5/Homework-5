namespace Homework1.f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -9,-8,-7,-6,-5,-4,-3,-2,-1,0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int i = 0;
            int average = 0;
            while (i < arr.Length)
            {
                if (arr[i] < 0 && arr[i] / 7 == 0)
                {
                    average += arr[i];
                    average++;
                }
                i++;
            }
            Console.WriteLine(average);
        }
    }
}
