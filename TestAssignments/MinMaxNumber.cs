using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignments
{
    class MinMaxNumber
    {
        //Get the Largest and Smallest of 10 numbers
        static void Main(string[] args)
        {

            int[] num = new int[3];

            try {
                Console.WriteLine("Enter 3 numbers:");

                for (int i = 0; i < 3; i++)
                {
                    num[i] = Convert.ToInt32(Console.ReadLine());
                }

                int MinNum = num[0];
                int MaxNum = num[2];

                DisplayMinNumber(MinNum, num);
                DisplayMaxNumber(MaxNum, num);
             
                //Could also Use Min Max function 
                Console.WriteLine("Min Number with Min function = " +num.Min());
                Console.WriteLine("Max Number with Max function = " + num.Max());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
         }

        //Get the smallest number
        public static void DisplayMinNumber(int MinNum, int[] Num)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Num[i] < MinNum)
                {
                    MinNum = Num[i];
                }
            }
            Console.WriteLine("Smallest Number is : " + MinNum);
        }

        //Get the largest number
        public static void DisplayMaxNumber(int MaxNum, int[] Num)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Num[i] > MaxNum)
                {
                    MaxNum = Num[i];
                }
            }
            Console.WriteLine("Largest Number is : " + MaxNum);
        }
    }
}