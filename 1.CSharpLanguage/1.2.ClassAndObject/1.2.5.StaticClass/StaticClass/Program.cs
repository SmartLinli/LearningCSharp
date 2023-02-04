using static System.Console;																

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im23 = new Class(infomationManagement, 2023);
            Student boy = Student.Create("3230707001", "张三", Gender.MALE, im23);          
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
