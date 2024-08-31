using System;

namespace StaticMethod
{
    public class Student
    {
        private string name;
        private int rollno;
        private static string college="BBDIT";
        public Student (string name, int rollno)
        {
            this.name = name;
            this.rollno = rollno;
        }
        public static void Change()
        {
            college = "CodeGym";
        }
        public void Display()
        {
            Console.WriteLine("{0}\nSo thu tu: {1}\nTen: {2}",college,rollno,name);
        }
       
    }
}