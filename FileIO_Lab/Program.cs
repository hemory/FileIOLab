using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;

namespace FileIO_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = @"C:\Users\hphifer\source\repos\FileIO_Lab\FileIO_Lab\StudentData.txt";

            //Create a list of students
            List<Student> students = new List<Student>();



            //Add a student to the list
            students.Add(new Student("Alfred", "Hitchcock", "Science"));


            //Create a list of strings for studentCollection
            List<string> studentCollection = new List<string>();

            foreach (Student student in students)
            {
                studentCollection.Add($"{student.FirstName}|{student.LastName}|{student.ClassSubject}");
            }

            using (StreamWriter sw = new StreamWriter(textPath))
            {
                foreach (string student in studentCollection)
                {
                    sw.WriteLine(student);
                }
            }

            ReadAndFormatText(textPath);

            Console.ReadLine();

        }

        private static void ReadAndFormatText(string textPath)
        {
            using (StreamReader sr = new StreamReader(textPath))
            {
                string line = sr.ReadToEnd();

                string[] textArray = line.Split('|');

                foreach (string formattedLine in textArray)
                {
                    Console.Write($" {formattedLine}");
                }
            }
        }
    }
}
