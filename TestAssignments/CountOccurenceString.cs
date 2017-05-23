using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignments
{
    class CountOccurenceString
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the String: ");
                string str = Console.ReadLine();
                int cntThe = CountOccurenceOfThe(str, "the");
                Console.WriteLine("No. of Occurences of 'the' are: " + cntThe);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        public static int CountOccurenceOfThe(string str, string pattern)
        {
            string[] splitStrings = str.Split(' ');
            int cnt = 0;

            foreach (string splitString in splitStrings)
            {
                 if(String.Equals(splitString, pattern, StringComparison.OrdinalIgnoreCase))
                {
                     cnt += 1;
                }
            }
            return (cnt); 
        }
    }
}
