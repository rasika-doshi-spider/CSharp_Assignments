using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignments
{
    class BinaryTriangle
    {
        static void Main(string[] args)
        {
            int rows =0, lastInt = 0;
            Console.WriteLine("Enter number of rows:");
            Int32.TryParse(Console.ReadLine(), out rows);
           
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<(i+1);j++)
                {
                    if(lastInt == 0)
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                    else if(lastInt == 1)
                    {
                        Console.Write("0");
                        lastInt = 0;
                    }
                }
                Console.Write("\n");
            }
        }

    }
}
