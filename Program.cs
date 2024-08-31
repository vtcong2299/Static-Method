using System;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[]args)
        {
            Student.Change();
            Student s1= new Student("Thao", 1);
            Student s2= new Student("Cong", 2);
            Student s3= new Student("Hoang", 3);
            s1.Display();
            Console.WriteLine();
            s2.Display();
            Console.WriteLine();
            s3.Display();
        }
    }
}