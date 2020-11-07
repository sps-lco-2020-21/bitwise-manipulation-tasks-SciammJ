using System;

namespace BitwiseOperators
{
    class Program
    {
        static int rightMost(int input)
        {
            string inputString = Convert.ToString(input);
            int i = Convert.ToInt32(inputString, 2);
            return i & 1;
        }

        static string threeRightMost(int input)
        {
            string inputString = Convert.ToString(input);
            int i = Convert.ToInt32(inputString, 2);
            int leaver = i & 7;
            return Convert.ToString(leaver, 2);
        }

        static int leftMost(int input)
        {
            string inputString = Convert.ToString(input);
            int i = Convert.ToInt32(inputString, 2);
            return i >> 4;
        }

        static string threeLeftMost(int input)
        {
            string inputString = Convert.ToString(input);
            int i = Convert.ToInt32(inputString, 2);
            return Convert.ToString(i >> 2, 2);
        }

        static string removeRightMost(int input)
        {
            string inputString = Convert.ToString(input);
            int i = Convert.ToInt32(inputString, 2);
            return Convert.ToString(i >> 1, 2);
        }

        static string removeThreeRightMost(int input)
        {
            string inputString = Convert.ToString(input);
            int i = Convert.ToInt32(inputString, 2);
            return Convert.ToString(i >> 3, 2);
        }

        static string removeLeftMost(int input)
        {
            string inputString = Convert.ToString(input);
            int i = Convert.ToInt32(inputString, 2);
            return Convert.ToString(i & 15, 2);
        }

        static string removeThreeLeftMost(int input)
        {
            string inputString = Convert.ToString(input);
            int i = Convert.ToInt32(inputString, 2);
            return Convert.ToString(i & 3, 2);
        }

        static string substring(int input)
        {
            string inputString = Convert.ToString(input);
            int i = Convert.ToInt32(inputString, 2);
            return Convert.ToString((i & 15) >> 1, 2);
        }

        static string toRight(int input)
        {
            string inputString = Convert.ToString(input);
            int i = Convert.ToInt32(inputString, 2);
            string newBinary = Convert.ToString((i & 16) >> 4);
            string newI = Convert.ToString(i & 15, 2);
            return newI + newBinary;
        }

        static int countSetBits(int x)
        {
            string binary = Convert.ToString(x, 2);
            int oneCounter = 0;
            foreach(char i in binary)
            {
                if(i == '1')
                {
                    oneCounter += 1;
                }
            }
            return oneCounter;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(rightMost(10101));
            //Console.WriteLine(rightMost(11111));
            //Console.WriteLine(rightMost(11100));
            //Console.WriteLine(threeRightMost(10101));
            //Console.WriteLine(threeRightMost(11111));
            //Console.WriteLine(threeRightMost(11100));
            //Console.WriteLine(leftMost(10101));
            //Console.WriteLine(leftMost(11111));
            //Console.WriteLine(leftMost(11100));
            //Console.WriteLine(threeLeftMost(10101));
            //Console.WriteLine(threeLeftMost(11111));
            //Console.WriteLine(threeLeftMost(11100));
            //Console.WriteLine(removeRightMost(10101));
            //Console.WriteLine(removeRightMost(11111));
            //Console.WriteLine(removeRightMost(11100));
            //Console.WriteLine(removeThreeRightMost(10101));
            //Console.WriteLine(removeThreeRightMost(11111));
            //Console.WriteLine(removeThreeRightMost(11100));
            //Console.WriteLine(removeLeftMost(10101));
            //Console.WriteLine(removeLeftMost(11111));
            //Console.WriteLine(removeLeftMost(11100));
            //Console.WriteLine(removeThreeLeftMost(10101));
            //Console.WriteLine(removeThreeLeftMost(11111));
            //Console.WriteLine(removeThreeLeftMost(11100));
            //Console.WriteLine(substring(10101));
            //Console.WriteLine(substring(11111));
            //Console.WriteLine(substring(11100));
            //Console.WriteLine(toRight(10101));
            //Console.WriteLine(toRight(11111));
            //Console.WriteLine(toRight(11100));
            //Console.WriteLine(countSetBits(3));
            //Console.WriteLine(countSetBits(256));



        }
    }
}
