namespace Homework1.h
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -29, -27, -19, -15, -12, -9, -6, -2, 1, 9, 20, 38, 41, 95 };
            int i = 0;
            while (i < arr.Length)
            {
                if (arr[i] < 0)
                {
                    
                    i++;
                }
                
            }
            Console.WriteLine(i);
            int i1 = 0;
            while (i1 < arr.Length)
            {
                if (arr[i1] > 0)
                {
                    

                    i1++;
                }
                
            }
            Console.WriteLine(i1);
        }
    }
}
