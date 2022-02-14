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
		public string Number { get; }                                                   
		public string Name { get; }
		public Gender Gender { get; }
		public Class Class { get; private set; }
        public void ShowInfo()
        {
            var info =
                $"新生信息：\n" +
                $"学号：{this.Number,-15}姓名：{this.Name}\n" +
                $"性别：{(this.Gender == Gender.MALE ? "男" : "女"),-14}班级：{this.Class.ShortName,-13}\n" +
                $"专业：{this.Class.Major.Name}";
            WriteLine(info);
        }
        public Student(string number, string name, Gender gender)                       //定义构造函数（重载1）；
        {
            this.Number = number;														
            this.Name = name;
            this.Gender = gender;
        }
        public Student(string number, string name, Gender gender, Class currentClass)   //定义构造函数（重载2）；
            : this(number, name, gender)                                                //构造函数初始化器，用于调用参数匹配的其它构造函数；
        {                                                                               
            this.Class = currentClass;
        }
    }
}
