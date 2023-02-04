using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im23 = new Class(infomationManagement, 2023);
            Major acupuncture = new Major("针灸学", "针灸");

            Student boy = Student.Create("3230707001", "张三", Gender.MALE, im23);
            boy.TransferTo(acupuncture);                                            //调用扩展方法；

            Student girl = Student.Create("3230707002", "李四", Gender.FEMALE);
            girl.EnrollBy(infomationManagement);
            Read();
        }
    }
}
