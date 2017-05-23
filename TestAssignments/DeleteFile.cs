using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignments
{
    class DeleteFile
    {
        static void Main(string[] args)
        { 
            string path = @"E:\Example.txt";
            if (!File.Exists(path))
            {
                var fileStream = File.Create(path);
                fileStream.Close();
                Console.WriteLine("File Created Successfully @ " +path);
   
            }

            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File Deleted Successfully from " + path);
            }
}
}
}
