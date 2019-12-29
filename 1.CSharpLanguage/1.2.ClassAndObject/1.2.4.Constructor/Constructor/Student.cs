using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	/// <summary>
	/// 性别；
	/// </summary>
    public enum Gender
    {
        FEMALE,
        MALE
    }
	/// <summary>
	/// 学生；
	/// </summary>
    public class Student                                                    
    {
		public string Number { get; }                                                   //省略set访问器，可实现只读属性；
		public string Name { get; }														//但此类只读属性只能在初始化时赋值，其后不再允许赋值；
		public Gender Gender { get; }
		public DateTime BirthDate { get; set; }
		public int Age
		=>	DateTime.Now.Year - this.BirthDate.Year;
		public string PhoneNumber { get; set; }
		public Class Class { get; set; }
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		public Student(string number, string name, Gender gender)                       //定义构造函数；
		{																				//编译器将不再自动提供默认的（无参数）构造函数；
			this.Number = number;														//构造函数能对省略set访问器的只读属性进行初始化；
            this.Name = name;
            this.Gender = gender;
        }
    }
}
