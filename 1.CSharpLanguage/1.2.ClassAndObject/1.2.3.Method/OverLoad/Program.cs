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
            
            girl.TransferTo(infomationManagement);                                     
			girl.EnrollBy(infomationManagement); 
            girl.EnrollBy(acupuncture);
            girl.TransferTo(acupuncture, 2021);                                            
            Read();
        }
    }
}
