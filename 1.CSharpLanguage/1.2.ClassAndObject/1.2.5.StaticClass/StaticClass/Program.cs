using static System.Console;																

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im21 = new Class(infomationManagement, 2021);
            Student boy = Student.Create("3210707000", "张三", Gender.MALE, im21);          
            if (boy == null)
            {
                return;
            }
            boy.Nationality = Nationality.HAN;                                              
			boy.PhoneNumber = "18900001111";
			StudentUi.Display(boy);                                                         //调用静态类的静态方法；
            Read();
        }
    }
}
