namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            int i = 0;
            int result = 0;
            while (i < arr.Length)
            {
                if (arr[i] < 15 && (arr[i]/3==0))
                {
                    result*=arr[i];
                    result++;
                }
                i++;
            }
            Console.WriteLine(result);
            
        }
    }
}
