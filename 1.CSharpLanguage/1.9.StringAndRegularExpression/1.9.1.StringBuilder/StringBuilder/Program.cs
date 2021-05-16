using static System.Console;

namespace SmartLin.LearningCSharp.StringAndRegularExpression
{
	class Program
	{
		static void Main()
		{
			User newUser = User.Create("3210707001", "MyPassword7001");
			WriteLine($"用户{newUser.Number}注册成功，加密后的密码为：{newUser.Password}\n");
			newUser.ModifyPassword("NewPassword2021");
			WriteLine($"用户{newUser.Number}修改密码成功，加密后的新密码为：{newUser.Password}\n");
			Read();
		}
	}
}
