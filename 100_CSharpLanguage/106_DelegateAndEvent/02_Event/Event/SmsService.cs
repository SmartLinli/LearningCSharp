using static System.Console;

namespace SmartLin.LearningCSharp.DelegateAndEvent
{
	/// <summary>
	/// 短信管理器；
	/// </summary>
	public class SmsService
	{
		/// <summary>
		/// 通知；
		/// </summary>
		/// <param name="sender">事件发送方</param>
		/// <param name="e">选课事件参数</param>
		public static void InformAfterSelectCourse(object sender, SelectCourseEventArgs e)          //注册至事件的函数的签名必须与委托定义一致；
		{
			Student student = sender as Student;
			WriteLine($"\n发送短信至手机{student.PhoneNumber}：已成功选修《{e.CourseName}》。\n");
		}
	}
}
