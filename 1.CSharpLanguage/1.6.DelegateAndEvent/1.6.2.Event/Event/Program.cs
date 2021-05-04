using static System.Console;

namespace SmartLin.LearningCSharp.DelegateAndEvent
{
	class Program
	{
		static void Main()
		{
			Student student = new Student("3200707001", "闭敏媛")
			{
				PhoneNumber = "15699996666"
			};
			BookOrderManager bookOrderManager = new BookOrderManager();
			student.SelectCourseEvent += bookOrderManager.AddBookOrder;                  //为事件注册处理函数；事件不能通过=赋值，必须通过+=注册（订阅）；
			student.SelectCourseEvent += SmsService.InformAfterSelectCourse;
			student.ShowMenu();
			Read();
		}
	}
}
