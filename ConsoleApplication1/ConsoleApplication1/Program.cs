using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello github");
        }
		public static bool IsOdd(int n)
		{
			if (n % 2 == 0)
				return false;
			else
				return true;
		}
        public static bool IsEvent(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i < n; i++)
            { 
                    if (n % i == 0)
                        return false;
            }
            return true;
        }
        public static int Square(int n)
        {
            //handle negative input
            if (n < 0)
                n = -n;
            // Initialize result 
            int y = n;
            // Add n to res n-1 times 
            for (int i = 1; i < n; i++)
                y = n*n;
                    return y;
        }
        public static int Cube(int n)
        {
            if (n < 0)
                n = -n;
            int y = n;
            for (int i = 1; i < n; i++)
                y = n*n*n;
            return y;

        } 
        public static int pow(int x, int y)
        {

        }
    }
}
