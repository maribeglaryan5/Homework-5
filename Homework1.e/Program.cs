namespace Homework1.e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int i = 0;
            int average = 0;
            while (i < arr.Length)
            {
                if (i > 0)
                { 
                average = +arr[i];
                average++;
                }
                i++;
            }
            Console.WriteLine(average);

        }
    }
}
