using static System.Console;

namespace SmartLin.LearningCSharp.StringAndRegularExpression
{
	class Program
	{
		static void Main()
		{
			User newUser = User.Create("3230707001", "MyPassword", "3230707001@fjtcm.edu.cn");
			if (newUser != null)
			{
				WriteLine($"用户{newUser.Number}注册成功，加密后的密码为：{newUser.Password}\n");
			}
			Read();
		}
	}
}
