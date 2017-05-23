using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignments
{
    class DuplicateElementsArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements to be stored in the array");
            int total;
            Int32.TryParse(Console.ReadLine(), out total);

            int[] arrInt = new int[total];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < arrInt.Length; i++)
            {
                arrInt[i] = int.Parse(Console.ReadLine());
            }

            FindDuplicateElements(arrInt);
            //FindDuplicatesWithDictionary(arrInt);
        }

        public static void FindDuplicateElements(int[] arrInt)
        {

            for (int i = 0; i < arrInt.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arrInt.Length; j++)
                {
                    if (arrInt[i] == arrInt[j])
                    {
                        count = count + 1;
                    }
                }
                Console.WriteLine(arrInt[i] + " repeats " + count + " times");
            }

        }

        public static void FindDuplicatesWithDictionary(int[] arrInt)
        {
            var dict = new Dictionary<int, int>();
 
            foreach (var element in arrInt)
            {
                if (dict.ContainsKey(element)) dict[element]++;
                else dict[element] = 1;
            }
            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times", pair.Key, pair.Value);
 
        }
    }
}