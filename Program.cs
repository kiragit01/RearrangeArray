using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RearrangeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 1, -2, -5, 2, -4 };
            nums = RearrangeArray(nums);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static int[] RearrangeArray(int[] nums)
        {
            int n = nums.Length;
            int[] plus = new int[n];
            int[] minus = new int[n];
            int f1 = 0, f2 = 1;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] >= 0)
                {
                    plus[f1] = nums[i];
                    f1+=2;
                }
                else
                {
                    minus[f2] = nums[i];
                    f2+=2;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if(i % 2 == 0) nums[i] = plus[i];
                else nums[i] = minus[i];
            }
            return nums;
        }
    }
}
