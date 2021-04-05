using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	class Program
    {
        static void Main()
        {
            /*定义专业、班级*/
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im21 = new Class(infomationManagement, 2021);
            /*定义新生、录取并显示消息*/
            Student newGuy = new Student("3210707000", "张三", Gender.MALE);
            var result= newGuy.EnrollBy(infomationManagement);                          
            if (result.IsSuccess)
            {
                WriteLine($"消息：{result.Message}");
            }
            else
            {
                WriteLine($"警告：{result.Warning}");
            }
            Read();
        }
    }
}
