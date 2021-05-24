using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");           
            Class im18=new Class(infomationManagement,2018);
            
            Student boy = Student.Create("3180707000", "张三", Gender.MALE, im18);          //调用类的静态方法；
            StudentUi.Display(boy);                                             //调用静态类的静态方法；
            
            Student girl = Student.Create("3190707000", "李四", Gender.FEMALE);
            girl.EnrollByMajor(infomationManagement);
            StudentUi.Display(girl);
            
            Major acupuncture = new Major("针灸学", "针灸");
            boy.TransferToMajor(acupuncture);
            
            boy.PhoneNumber = "18900001111";
            Console.Read();
        }
    }
}
