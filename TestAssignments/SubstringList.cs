using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignments
{
    class SubstringList
    {
        static void Main(string[] args)
        {
            List<string> subString = new List<string>();
            Console.WriteLine("Enter a String without any whitespaces:");
            string str = Console.ReadLine();
            subString = GetAllSubstring(str);

            Console.WriteLine("Substrings of the string are: ");
            for (int i=0;i<subString.Count;i++)
                Console.WriteLine(subString[i]); 
        }

        internal static List<string> GetAllSubstring(String mainString)
        {
            try
            {
                var stringList = new List<string>();
                if (!string.IsNullOrEmpty(mainString))
                {
                    for (int i = 0; i < mainString.Length; i++) //i is starting position
                    {
                        for (int j = 2; j + i <= mainString.Length; j++) //j is number of characters to get
                        {
                            if (!stringList.Contains(mainString.Substring(i, j)))
                            {
                                stringList.Add(mainString.Substring(i, j));
                            }
                        }
                    }

                }

                return stringList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return null;
        }
    }
}
