using static System.Console;

namespace SmartLin.LearningCSharp.DelegateAndEvent
{
	class Program
	{
		static void Main()
		{
			Student student = new Student("3180707001", "周林好")
			{
				PhoneNumber = "15659911355"
			};
			BookOrderManager bookOrderManager = new BookOrderManager();
			student.AfterSelectCourse = bookOrderManager.AddBookOrder;                  //委托引用指定的函数；
			student.AfterSelectCourse += SmsService.InformAfterSelectCourse;            //委托重载了运算符，从而引用更多函数，实现多播委托；
			student.ShowMenu();
			/*
            student.AfterSelectCourse(student, "JAVA");                                 //公有委托可被随意调用；若将委托定义为只写，虽可避免被随意调用，但将无法使用+=实现多播；
            */
			Read();
		}
	}
}
