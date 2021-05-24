using System;

namespace SmartLin.LearningCSharp.ErrorAndException
{
    public partial class Student                                                        //定义部分类；                                                
    {
        public string Email
        {
            get;
            set;
        }
        public static Student Create(string number, string name, Gender gender)         //定义静态方法；
        {
            if (number.Length != 10)
            {
                Console.WriteLine("学号长度应为10位！");
                return null;
            }
            else
            {
                Student student = new Student(number, name, gender);                    //调用私有构造函数；
                return student;
            }
        }
        public static Student Create(string number, string name, Gender gender, Class currentClass)
        {
            Student student = Create(number, name, gender);                             //调用本类的静态方法；
            if (student!=null)
            {
                student.Class = currentClass;
            }
            return student;
        }
    }
}
