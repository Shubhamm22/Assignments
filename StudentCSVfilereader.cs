using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Demo
{
    class StudentCSVfilereader
    {
        
        public void validatefilepath()
        {
            string filepath = (@"D:\visual studio\info.csv");
            if (File.Exists(filepath))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("file does not exists");
            }

        }
        public void GetALLStudents()
        {
            string a = File.ReadAllLines(@"D:\visual studio\info.csv");

           


        }
    }
}
