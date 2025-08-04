using System;
using System.Collections.Generic;

namespace mssa_5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 1 };
            int[] nums2 = { 1, 2, 3, 4 };
            int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            Console.WriteLine(ContainsDuplicate(nums1)); // Output: True
            Console.WriteLine(ContainsDuplicate(nums2)); // Output: False
            Console.WriteLine(ContainsDuplicate(nums3)); // Output: True
        }

        static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();
            foreach (int num in nums)
            {
                if (!seen.Add(num))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
