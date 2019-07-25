using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
	/// <summary>
	/// 短信管理器；
	/// </summary>
	public class SmsManager
	{
		/// <summary>
		/// 通知；
		/// </summary>
		/// <param name="student">学生</param>
		/// <param name="message">消息</param>
		public static void Inform(Student student, string message)
			=> WriteLine("已通知学生{student.Name}：{message}。\n");
	}
}
