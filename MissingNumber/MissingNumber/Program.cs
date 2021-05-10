using System;

namespace MissingNumber
{
    class Program
    {
        static int getMissingNo(int[] A, int n)
        {
            int total = (n + 1) * (n + 2) / 2;
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum = sum + A[i];
            total = total - sum;
            return total;
        }

        public static void Main()

        {
            int[] A = { 1, 2, 4, 5, 6 };
            int miss = getMissingNo(A, 5);
            Console.WriteLine(miss);
        }
    }
}   
