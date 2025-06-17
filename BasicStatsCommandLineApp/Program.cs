using System.Numerics;

namespace BasicStatsCommandLineApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many numbers are you entering?");
            int len = Convert.ToInt32(Console.ReadLine());

            int count = len, sum=0, max=int.MinValue, min=int.MaxValue;
            float avg;
            int[] nums = new int[len];

            Console.WriteLine("Enter numbers: ");
            for (int i = 0; i < len; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < len; i++) { 
                sum += nums[i];
                if (nums[i] > max) max = nums[i];
                if (nums[i] < min) min = nums[i];
            }
            avg = (float)sum / len;

            Console.WriteLine("------------Basic Stats of Your Numbers----------------");
            Console.WriteLine($" Count: {count}\n Sum: {sum}\n Max: {max}\n Min: {min}\n Avg: {avg}");
        }
    }
}
