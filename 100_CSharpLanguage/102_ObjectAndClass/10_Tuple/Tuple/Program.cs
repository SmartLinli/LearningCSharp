using SmartLin.LearningCSharp.ClassAndObject.Model;
using SmartLin.LearningCSharp.ClassAndObject.Ui;
using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	class Program
    {
        static void Main()
        {
            /*创建专业、班级*/
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im18 = new Class(infomationManagement, 2018);
            /*创建学生并显示*/
            Student boy = Student.Create("3180707000", "张三", Gender.MALE, im18);           //调用类的静态方法；    
            StudentUi.Display(boy);                                                         //调用静态类的静态方法；
            /*创建新生、录取并显示*/
            Student girl = Student.Create("3190707000", "李四", Gender.FEMALE);
            var result= girl.EnrollByMajor(infomationManagement);                           //定义匿名类型，用于保存方法返回的元组对象；
            if (result.IsSuccess)
            {
                Console.WriteLine($"消息：{result.Message}");
            }
            else
            {
                Console.WriteLine($"警告：{result.Warning}");
            }
            Console.Read();
        }
    }
}
