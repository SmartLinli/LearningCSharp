using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 本科生；
	/// </summary>
	public class Undergraduate : Student
	{
		/// <summary>
		/// 班级
		/// </summary>
		public string Class { get; private set; }
		/// <summary>
		/// 转专业；
		/// </summary>
		/// <param name="newClass">新班级</param>
		public void TransferToMajor(string newClass)
		{
			if (this.Class == null)
			{
				WriteLine($"{this.Name}尚未被任何专业录取，无法转专业。");
				return;
			}
			this.Class = newClass;
			WriteLine($"{this.Name}已转至新专业，并分配至{newClass}班。");
		}
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		/// <param name="currentClass">班级</param>
		public Undergraduate(string number, string name, string gender, string currentClass)
			: base(number, name, gender)
		{
			this.Class = currentClass;
		}
	}
}
