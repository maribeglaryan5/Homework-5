using System.Security.Cryptography;

namespace Homework2.e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 227, 3333, 3455, 22234, 776543, 233444555 };
            int i = 0;
            int max = 0;
            while (i < arr.Length)
            {
                if (arr[i] > arr[i])
                {
                    max = arr[i];
                }
                i++;
            }
            Console.WriteLine(max);
            int i1 = 0;
            int min = 0;
            while (i1 < arr.Length)
            {
                if (arr[i1] < arr[i1])
                {
                    min = arr[i1];
                }
                i++;
            }
            Console.WriteLine(min);
            int i2 = 0;
            int dif = 0;
            while (i2 < arr.Length)
            {
                if (arr[i] - arr[i1] != 0)
                {
                    dif = arr[i2];
                }
                i++;
            }
            Console.WriteLine(dif);
        }
    }
}
