using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignments
{
    class OddEvenNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements to be stored in the array");
            int total;
            Int32.TryParse(Console.ReadLine(), out total);

            int[] arrInt = new int[total];
            Console.WriteLine("Enter the array elements:");
            for(int i=0;i<arrInt.Length;i++)
            {
                arrInt[i] = int.Parse(Console.ReadLine());
            }

            SeperateOddEvenNumbers(arrInt);
        }

        public static void SeperateOddEvenNumbers(int[] arrInt)
        {
            int[] OddNum = new int[arrInt.Length];
            int[] EvenNum = new int[arrInt.Length];
            int j = 0, k=0;
            

            for (int i=0;i< arrInt.Length;i++)
            {
                if(arrInt[i]%2 == 0)
                {
                    EvenNum[j] = arrInt[i];
                    j++;
                }
                else
                {
                    OddNum[k] = arrInt[i];
                    k++;
                }
            }

            Console.WriteLine("Even Numbers are: ");
            for (int i=0;i<j;i++)
            {
                Console.WriteLine(EvenNum[i]);
            }
            Console.WriteLine("Odd Numbers are: ");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(OddNum[i]);
            }
        }
    }
}
