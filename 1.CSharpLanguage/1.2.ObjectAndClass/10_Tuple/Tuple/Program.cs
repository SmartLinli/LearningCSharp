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
            /*创建学生并介绍*/
            Student boy = new Student("3180707000", "张三", Gender.MALE, im18);          
            boy.Intro();                                                        
            /*创建新生、录取并显示消息*/
            Student girl = new Student("3190707000", "李四", Gender.FEMALE);
            var result= girl.EnrollByMajor(infomationManagement);                          
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
