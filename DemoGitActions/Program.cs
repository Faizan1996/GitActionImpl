using System;

namespace DemoGitActions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddTwoNumbers(int.MaxValue, 11));
        }

        public static int AddTwoNumbers(int a, int b)
        {
            //if (a == int.MaxValue || b == int.MaxValue)
            //{
            //    throw new OverflowException();
            //}
            int res = checked (a + b);
            return res;
        }

        public static int SubtractTwoNumbers(int a, int b)
        {
            //if (a == int.MinValue|| b == int.MinValue)
            //{
            //    throw new OverflowException();
            //}
            int res = checked (a - b);
            return res;
        }
    }
}
