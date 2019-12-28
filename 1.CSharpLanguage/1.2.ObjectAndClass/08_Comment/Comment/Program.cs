using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            /*定义专业、班级；*/
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im18 = new Class(infomationManagement, 2018);
            /*定义学生；介绍；*/
            Student boy = new Student("3180707000", "张三", Gender.MALE, im18);              
            boy.Intro();
			/*定义新生；录取；介绍；*/
			Student girl = new Student("3200707000", "李四", Gender.FEMALE);
            girl.EnrollByMajor(infomationManagement);
            girl.Intro();
            /*学生转专业；*/
            Major acupuncture = new Major("针灸学", "针灸");
            boy.TransferToMajor(acupuncture);
            Read();
        }
    }
}
