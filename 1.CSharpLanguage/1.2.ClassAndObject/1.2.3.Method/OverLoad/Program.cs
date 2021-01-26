using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	class Program
    {
        static void Main()
        { 
            Major infomationManagement = new Major();                                          
            infomationManagement.Name = "信息管理与信息系统";                                  
            infomationManagement.ShortName = "信管";
            Major acupuncture = new Major();
            acupuncture.Name = "针灸学";
            acupuncture.ShortName = "针灸";

            Student girl = new Student();
            girl.Name = "李四";
            
            girl.Intro();                                                                   //调用方法；
            girl.TransferToMajor(infomationManagement);                                     //实际信息以及处理过程被隐藏，实现了封装；
			girl.EnrollByMajor(infomationManagement); 
            girl.EnrollByMajor(acupuncture);
            girl.Intro();
            girl.TransferToMajor(acupuncture, 2021);                                            
            girl.Intro();
            Read();
        }
    }
}
