using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE_HANDLING
{                 
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create File
            String filePath = "C:\\Users\\Admin1\\Documents\\File \\HELLO.TXT"; //Wrong File Name

            try
            {
                using (FileStream fs = File.Create(filePath))
                {
                    // File Created
                }
                //File Write
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("hey");
                    writer.WriteLine("v");
                }

                //File Read
                using (StreamReader fs = new StreamReader(filePath))
                {
                    String line;
                    while ((line = fs.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }


                //File Read Letter by Letter
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    int byteValue;
                    while ((byteValue = fs.ReadByte()) != -1)
                    {
                        char charValue = (char)byteValue;
                        Console.WriteLine(charValue);
                    }
                }
                Console.WriteLine();

                //File Info
                FileInfo fileInfo = new FileInfo(filePath);
                Console.WriteLine(fileInfo.Length);
                Console.WriteLine(fileInfo.FullName);
                Console.WriteLine(fileInfo.Name);
                Console.WriteLine(fileInfo.Exists);
                Console.WriteLine(fileInfo.IsReadOnly ? "False" : "True");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Directory Not Found Exception");
                Console.WriteLine();

                Console.WriteLine("Run With Correct FilePath");


                filePath = "C:\\Users\\Admin1\\Documents\\File Handling\\HELLO.TXT"; // Correct File Name

                using (FileStream fs = File.Create(filePath))
                {
                    // File Created
                }

                //File Write
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("hey");
                    writer.WriteLine("v");
                }

                //File Read
                using (StreamReader fs = new StreamReader(filePath))
                {
                    String line;
                    while ((line = fs.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

                //File Read Letter by Letter
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    int byteValue;
                    while ((byteValue = fs.ReadByte()) != -1)
                    {
                        char charValue = (char)byteValue;
                        Console.WriteLine(charValue);
                    }
                }
                Console.WriteLine();

                //File Info
                FileInfo fileInfo = new FileInfo(filePath);
                Console.WriteLine(fileInfo.Length);
                Console.WriteLine(fileInfo.FullName);
                Console.WriteLine(fileInfo.Name);
                Console.WriteLine(fileInfo.Exists);
                Console.WriteLine(fileInfo.IsReadOnly ? "False" : "True");
            }
        }
    }
}
