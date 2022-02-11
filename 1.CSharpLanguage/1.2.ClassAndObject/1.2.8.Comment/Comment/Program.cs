using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            /*定义专业、班级、学生；*/
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Major acupuncture = new Major("针灸学", "针灸");
            Class im22 = new Class(infomationManagement, 2022);
            Student girl = new Student("3220707002", "李四", Gender.FEMALE, im22);
            /*学生介绍；转专业；*/
            girl.Intro();
            girl.TransferTo(acupuncture);
            /*定义新生；录取；介绍；*/
            Student newGuy = new Student("3220707001", "张三", Gender.MALE);
            newGuy.EnrollBy(infomationManagement);
            newGuy.Intro();
            Read();
        }
    }
}
