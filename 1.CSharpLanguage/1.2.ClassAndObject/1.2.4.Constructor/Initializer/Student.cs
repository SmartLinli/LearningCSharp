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
		public DateTime BirthDate { get; set; }
		public int Age
		=>	DateTime.Now.Year - this.BirthDate.Year;
		public string PhoneNumber { get; set; }
		public Class Class { get; private set; }
        public void ShowInfo()
        {
            var info =
                $"新生信息：\n" +
                $"学号：{this.Number,-15}姓名：{this.Name}\n" +
                $"性别：{(this.Gender == Gender.MALE ? "男" : "女"),-14}生日：{this.BirthDate:D}\n" +
                $"年龄：{this.Age,-15}手机号：{this.PhoneNumber}\n" +
                $"班级：{this.Class.ShortName,-13}专业：{this.Class.Major.Name}";
            WriteLine(info);
        }
        public Student(string number, string name, Gender gender)                       
        {
            this.Number = number;														
            this.Name = name;
            this.Gender = gender;
        }
        public Student(string number, string name, Gender gender, Class currentClass)   
            : this(number, name, gender)                                                
        {                                                                               
            this.Class = currentClass;
        }
    }
}
