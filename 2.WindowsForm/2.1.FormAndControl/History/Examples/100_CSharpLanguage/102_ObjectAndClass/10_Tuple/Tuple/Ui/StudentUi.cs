using System;
using SmartLin.LearningCSharp.ClassAndObject.Model;                                     //对项目默认命名空间以外的资源访问，可通过添加调用获得便利；

namespace SmartLin.LearningCSharp.ClassAndObject.Ui                                     //向文件夹添加的类，所在命名空间默认为项目默认命名空间+文件夹路径；
{
    /// <summary>
    /// 学生界面；
    /// </summary>
    public static class StudentUi
    {
        /// <summary>
        /// 显示；
        /// </summary>
        /// <param name="student">学生</param>
        public static void Display(Student student)
        {
            Console.WriteLine
                ("在校生信息：\n学号：{0,-15}姓名：{1}\n性别：{2,-14}手机号：{5}\n班级：{6,-13}专业：{7}\n"
                , student.Number
                , student.Name
                , student.Gender == Gender.MALE ? "男" : "女"
                , student.BirthDate
                , student.Age
                , student.PhoneNumber
                , student.Class.ShortName
                , student.Class.Major.Name);
        }
    }
}
