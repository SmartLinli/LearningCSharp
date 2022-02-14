using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");				
            Class im22 = new Class(infomationManagement, 2022);
            Student boy = new Student("3220707000", "张三", Gender.MALE, im22)				//调用构造函数（重载2）；
            {
                BirthDate = new DateTime(2004, 1, 2),                                       //还可在初始化器中对其余属性进行赋值；
                PhoneNumber = "18900001111"
            } ;
            boy.ShowInfo();
			Read();
        }
    }
}
