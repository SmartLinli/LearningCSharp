using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    public static class Display
    {
        public static void User(User user)
        {
            Console.WriteLine
                ("用户信息：\n编号：{0,-15}姓名：{1}\n性别：{2,-14}生日：{3:D}\n年龄：{4,-15}手机号：{5}"
                , user.Number
                , user.Name
                , user.Gender == Gender.MALE ? "男" : "女"
                , user.BirthDate
                , user.Age
                , user.PhoneNumber);
            user.Intro();                                                               //若子类重写基类的虚方法，则将调用子类重写的方法；
        }
        public static void Student(Student student)
        {
            Console.WriteLine
                ("在校生信息：\n学号：{0,-15}姓名：{1}\n性别：{2,-14}生日：{3:D}\n年龄：{4,-15}手机号：{5}\n班级：{6,-13}专业：{7}"
                , student.Number
                , student.Name
                , student.Gender == Gender.MALE ? "男" : "女"
                , student.BirthDate
                , student.Age
                , student.PhoneNumber
                , student.Class.ShortName
                , student.Class.Major.Name);
            student.Intro();                                                            //调用子类重写的方法；
        }
        public static void Faculty(Faculty faculty)
        {
            Console.WriteLine
                ("教职工信息：\n工号：{0,-15}姓名：{1}\n性别：{2,-14}生日：{3:D}\n年龄：{4,-15}手机号：{5}\n部门：{6}"
                , faculty.Number
                , faculty.Name
                , faculty.Gender == Gender.MALE ? "男" : "女"
                , faculty.BirthDate
                , faculty.Age
                , faculty.PhoneNumber
                , faculty.Department.Name);
            faculty.Intro();                                                            //调用子类重写的方法；
        }
    }
}
