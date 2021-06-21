using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            studentinfo _instance = new studentinfo();
            _instance.setid("s100");
            _instance.setname("shubham");
            _instance.setmarks(100);
            string idvalue = _instance.GetId();
            System.Console.WriteLine(idvalue);
            string namevalue = _instance.GetName();
            System.Console.WriteLine(namevalue);
            int marksvalue = _instance.Getmarks();
            System.Console.WriteLine(marksvalue);
            //StudentCSVfilereader _instance2 = new StudentCSVfilereader();
            //_instance2.ReadCsvFile();
            //Console.ReadLine();
            StudentCSVfilereader file1 = new StudentCSVfilereader();
            file1.validatefilepath();
            file1.GetALLStudents();
           
        }
    }
}
