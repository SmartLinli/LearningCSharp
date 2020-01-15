using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 本科生；
	/// </summary>
	public class Undergraduate 
    {
		/// <summary>
		/// 学号；
		/// </summary>
		public string Number { get; private set; }
		/// <summary>
		/// 姓名；
		/// </summary>
		public string Name { get; private set; }
		/// <summary>
		/// 导师服务；
		/// </summary>
		public IStudentInstructorService InstructorService { private get; set; }              //将派生于指定接口的不同对象赋予（注入）该属性，从而实现不同的行为；
		/// <summary>
		/// 分配导师；
		/// </summary>
		public void AssignInstructor()
		{
			WriteLine($"为{this.Name}分配导师：");
			this.InstructorService.Assign();
		}
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		public Undergraduate(string number, string name)
        {
			this.Number = number;
			this.Name = name;
		}
    }
}
