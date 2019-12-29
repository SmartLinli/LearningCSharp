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
    public class Student                                            //定义公有类；                      
    {
        public string Number;                                       
        public string Name;
        public Gender Gender;
        public DateTime BirthDate;
        public string PhoneNumber;
        public Class Class;                                         //类的数据成员的类型可以是其它类；
    }
}
