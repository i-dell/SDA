using System;
using System.IO;


namespace StudentData
{
    class StdData
    {
        public void WriteData()
        {
            FileStream fs = new FileStream("A:\\SDA\\Phase 1 Agile\\Practical\\Student_Data.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Student Marks");
            Console.WriteLine("Enter Student Name - Mark   : ");
            string message = Console.ReadLine();
            sw.WriteLine(message);
            Console.WriteLine("Done.");
            sw.Close();
            fs.Close();
        }
        public void AppendData()
        {
            FileStream fs = new FileStream("A:\\SDA\\Phase 1 Agile\\Practical\\Student_Data.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Student Marks");
            Console.WriteLine("Enter Student Name - Mark   : ");
            string message = Console.ReadLine();
            sw.WriteLine(message);
            Console.WriteLine("Done.");
            sw.Close();
            fs.Close();

        }
        public void ReadData()
        {
            FileStream fs = new FileStream("A:\\SDA\\Phase 1 Agile\\Practical\\Student_Data.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Student Marks");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while(str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            StdData stdData = new StdData();
            //stdData.WriteData();
            //stdData.AppendData();
             stdData.ReadData();

            Console.ReadKey();

        }
    }
}
