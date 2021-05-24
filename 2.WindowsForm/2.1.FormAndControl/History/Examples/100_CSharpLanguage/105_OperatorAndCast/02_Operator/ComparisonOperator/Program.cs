using System;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
    class Program
    {
        static void Main()
        {
            Student
                student = new Student("3180707001", "周林好")
                , sameStudent = new Student("3180707001", "<空>")
                , student2 = new Student("20180707001", "周林好");
            Console.WriteLine
                ("{0}号{1}同学与{2}号{3}同学{4}是同一人。"
                , student.Number
                , student.Name
                , sameStudent.Number
                , sameStudent.Name
                , student == sameStudent ? "" : "不");                 //调用比较运算符==的重载，判断双方是否相等；
            Console.WriteLine
                ("{0}号{1}同学与{2}号{3}同学{4}是同一人。"
                , student.Number
                , student.Name
                , student2.Number
                , student2.Name
                , student == student2 ? "" : "不");
            Console.Read();
        }
    }
}
