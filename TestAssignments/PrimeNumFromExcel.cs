using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestAssignments
{
    public class PrimeNumFromExcel
    {
        static void Main(string[] args)
        {
            getExcelFile();
        }

        public static void getExcelFile()
        {

            try
            {
                //Create COM Objects. Create a COM object for everything that is referenced
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\PrimeNum.xlsx");
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;
                int result = 0;
                string ExcelVal=string.Empty;

                //iterate over the rows and columns and print to the console as it appears in the file
                //excel is not zero based!!
                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        //new line
                        if (j == 1)
                            Console.Write("\r\n");

                        //write the value to the console
                        if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        {
                            int Num = -1;
                            ExcelVal = xlRange.Cells[i, j].Value2.ToString();

                            if (Int32.TryParse(xlRange.Cells[i, j].Value2.ToString(), out Num))
                            {
                                result = Check_Prime(Num);
                            }
                            else
                            {
                                result = 0;
                            }
                            if (result == 0)
                            {
                                Console.WriteLine("{0} is not a prime number", ExcelVal);
                            }
                            else
                            {
                                Console.WriteLine("{0} is  a prime number", ExcelVal);
                            }
                        }

                    }
                }


                //rule of thumb for releasing com objects:
                //  never use two dots, all COM objects must be referenced and released individually
                //  ex: [somthing].[something].[something] is bad

                //release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);

                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

        }
        catch(Exception e)
         {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
         }
}
        private static int Check_Prime(int num)
        {
            int i;
            for (i = 2; i < num; i++)
            {
                if(num%i== 0)
                {
                    return 0;
                }
            }
            if(num == i)
            {
                return 1;
            }
            return 0;
        }
  }
}   


