namespace Homework_2.d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 288, 2993, 222222, 456, 456543, 345676 };
            int i = 0;
            int max = 0;
            while (i < arr.Length)
            {
                if (arr[i] < arr[i])
                {
                    max = arr[i];

                }
                i++;
            }
            Console.WriteLine(max);
            int i1 = 0;
            int index = 0;
            while (i1 < arr.Length)
            {
                if ((arr[i1] < arr[index]))
                {
                    index = arr[i1];
                    index++;
                }
                i++;
            }
            Console.WriteLine(index);
        }
    }
}
