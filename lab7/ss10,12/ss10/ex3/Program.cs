using System;

namespace Students
{
    class StudentDetails
    {
        string _studentName = "Alexander";
        int _studID = 30;
        public StudentDetails()
        {
            Console.WriteLine("Student Name: " + _studentName);
            Console.WriteLine("Student ID: " + _studID);
        }
    }
}
namespace Examination
{
    class ScoreReport
    {
        public string Subject = "Science";
        public int Marks = 60;
        public ScoreReport()
        {
            Console.WriteLine("Subject: " + Subject);
            Console.WriteLine("Marks: " + Marks);
        }
        static void Main(string[] args)
        {
            Students.StudentDetails objStudents = new Students.StudentDetails();
            ScoreReport objReport = new ScoreReport();
            
        }
    }
}
