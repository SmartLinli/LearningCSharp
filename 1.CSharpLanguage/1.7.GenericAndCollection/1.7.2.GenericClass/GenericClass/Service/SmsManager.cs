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
		/// <param name="user">用户</param>
		/// <param name="message">消息</param>
		public static void Inform<T>(T user, string message)
		=>	WriteLine($"已通知用户{user}：{message}。\n");
	}
}
