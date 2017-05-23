using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignments
{
    class CountWordsLines
    {
        static void Main(string[] args)
        {
            string sentence = string.Empty;
            string inputText;
            int numLines = 0;

            try
            {
                Console.WriteLine("Input your text (type EXIT to terminate): ");
                do
                {
                    inputText = Console.ReadLine();

                    if (inputText.ToUpper() != "EXIT")
                    {
                        numLines++;
                        sentence = sentence + ' ' + inputText;
                    }
                } while (inputText.ToUpper() != "EXIT");

                Console.WriteLine("No. of lines =" + numLines);
                Console.WriteLine("Entered text is :" + sentence);

                string[] words = sentence.Split(' ');
                int cntChars = countCharcaters(sentence);

                int cnt = words.Length - 1;
                Console.WriteLine("No of words = " + cnt);
                Console.WriteLine("No of characters = " + cntChars);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        public static int countCharcaters(string sentence)
        {
            int result = 0;
            foreach (char c in sentence)
            {
                if (!char.IsWhiteSpace(c))
                {
                    result++;
                }
            }
            return result;

        }
    }
}