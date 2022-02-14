using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	public class Gender
	{
		public static readonly string FEMALE = "女";
		public static readonly string MALE = "男";
	}
	public class Student
	{
		public string Number { get; private set; }
		public string Name { get; private set; }
		public string Gender { get; private set; }
		public void ShowInfo()
		{
			var info =
				$"新生信息：\n" +
				$"学号：{this.Number,-15}姓名：{this.Name}\n" +
				$"性别：{this.Gender,-14}\n";
			WriteLine(info);
		}
		private Student(string number, string name, string gender)							//将构造函数定义为私有；                   
		{
			this.Number = number;
			this.Name = name;
			this.Gender = gender;
		}
        public static Student Create(string number, string name, string gender)				//在非静态类中定义静态方法；     
        {																					//无需实例化非静态类，即可调用其静态方法，从而实现创造行为模式等设计模式；
            if (number.Length != 10)
            {
				WriteLine("学号长度应为10位！");
				Read();
				return null;
			}
			Student student = new Student(number, name, gender);							//调用私有构造函数；
			return student;
        }
    }
}
