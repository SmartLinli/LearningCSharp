using System;

namespace SmartLin.LearningCSharp.Basics
{
    class ObjectOriented
    {
        public static void Main(string[] args)
        {
            Student newStudent = new Student("3180707000", "张三");
            newStudent.Save();
        }
    }
}
