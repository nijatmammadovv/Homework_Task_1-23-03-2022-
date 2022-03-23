using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Task_1_23_03_2022_.Models
{
    class Student : Person
    {
        public double IQRank { get; set; }
        public double LanguageRank { get; set; }


        public Student(string name, string surname, int age, double iqrank, double languagerank)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IQRank = iqrank;
            LanguageRank = languagerank;
        }
        //Checking the student's IQ and language test results
        public double ExamResult()
        {
            return IQRank + LanguageRank;
        }

    }
}
