using System;
using System.Collections.Generic;
using System.Text;

namespace FileIO_Lab
{
   public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassSubject { get; set; }

        public Student(string firstName, string lastName, string classSubject)
        {
            FirstName = firstName;
            LastName = lastName;
            ClassSubject = classSubject;
        }

    }
}
