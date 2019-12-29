using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");           
            Class im18=new Class(infomationManagement,2018);
			Major acupuncture = new Major("针灸学", "针灸");

			Student boy = Student.Create("3180707000", "张三", Gender.MALE, im18);        
			boy.TransferToMajor(acupuncture);											//调用扩展方法；

			Student girl = Student.Create("3190707000", "李四", Gender.FEMALE);
            girl.EnrollByMajor(infomationManagement);
            
			Read();
        }
    }
}
