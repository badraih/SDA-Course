using System;
using System.Collections.Generic;
using System.IO;

namespace ReadStudentData
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\beedo\OneDrive\سطح المكتب\SDA-Course\ReadStudentData\ReadStudentData\StudentData.txt";

            //if (File.Exists(file))
            //{
            //    // Read all the content in one string
            //    // and display the string
            //    Console.WriteLine("EXists");
            //    string str = File.ReadAllText(file);
            //    Console.WriteLine(str);
            //}

            Console.WriteLine("Student Data");

            // By using StreamReader
            if (File.Exists(file))
            {
                // Reads file line by line
                StreamReader Textfile = new StreamReader(file);
                string line;

                while ((line = Textfile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                Textfile.Close();

                Console.ReadKey();
            }
            Console.WriteLine();
        }


    }
}
