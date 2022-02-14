using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	public enum Gender
    {
        FEMALE,
        MALE
    }
    public class Nationality
    {
        public static readonly string HAN = "汉族";                                         //定义静态只读字段并初始化；
        public static readonly string QIANG = "羌族";
        public static readonly string SHE = "畲族";
    }
    public class Student
    {
		public string Number { get; private set; }
		public string Name { get; private set; }
		public Gender Gender { get; private set; }
		public string Nationality { get; set; }
		public void ShowInfo()
		{
			var info =
				$"新生信息：\n" +
				$"学号：{this.Number,-15}姓名：{this.Name}\n" +
				$"性别：{(this.Gender == Gender.MALE ? "男" : "女"),-14}民族：{this.Nationality}\n";
			WriteLine(info);
		}
		public Student(string number, string name, Gender gender)                       
		{
			this.Number = number;
			this.Name = name;
			this.Gender = gender;
		}
    }
}
