using System;
using System.Linq;

namespace C_Sharp_Basic
{
    public class Question61
    {
        public static void Q61()
        {   
            int[] nums = new int[] {-5, 30, 12, 40, -5, -5, 90};
            int[] arr = SortNumbers(nums);
            foreach (var num in arr) {
                Console.WriteLine(num.ToString());
            }
        }

        public static int[] SortNumbers(int[] arr)
        {
            int[] numbers = arr.Where(x => x!= -5).OrderBy(x => x).ToArray();
            int count = 0;
            return arr.Select(x => x >= 0 ? numbers[count++] : -5).ToArray();
        }
    }
}