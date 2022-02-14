using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public enum Gender
    {
        FEMALE,
        MALE
    }
    public class Student                                                    
    {
		public string Number { get; }                                                   //省略set访问器，可实现只读属性；
		public string Name { get; }														//但此类只读属性只能在初始化时赋值，其后不再允许赋值；
		public Gender Gender { get; }
		public Class Class { get; set; }
        public void ShowInfo()
        {
			var info=
				$"新生信息：\n" +
				$"学号：{this.Number,-15}姓名：{this.Name}\n" +
				$"性别：{(this.Gender == Gender.MALE ? "男" : "女"),-14}班级：{this.Class.ShortName,-13}\n" +
				$"专业：{this.Class.Major.Name}";
			WriteLine(info);
		}
		public Student(string number, string name, Gender gender)                       //定义构造函数；
		{																				//编译器将不再自动提供默认的（无参数）构造函数；
			this.Number = number;														//构造函数能对省略set访问器的只读属性进行初始化；
            this.Name = name;
            this.Gender = gender;
        }
    }
}
