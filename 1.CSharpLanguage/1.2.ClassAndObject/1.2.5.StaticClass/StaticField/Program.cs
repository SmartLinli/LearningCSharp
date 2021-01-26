using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im21 = new Class(infomationManagement, 2021);
			Student boy = new Student("3210707000", "张三", Gender.MALE, im21)            
			{
				PhoneNumber = "18900001111",
				Nationality = Nationality.SHE                                              //调用类的静态字段；
			};
			WriteLine
				($"新生信息：\n"
				+ $"学号：{boy.Number,-15}姓名：{boy.Name}\n"
				+ $"性别：{(boy.Gender == Gender.MALE ? "男" : "女"),-14}民族：{boy.Nationality}\n"
				+ $"年龄：{boy.Age,-15}手机号：{boy.PhoneNumber}\n"
				+ $"班级：{boy.Class.ShortName,-13}专业：{boy.Class.Major.Name}");
            Read();
        }
    }
}
