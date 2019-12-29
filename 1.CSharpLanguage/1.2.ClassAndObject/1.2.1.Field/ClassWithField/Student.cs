using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	/// <summary>
	/// 性别；
	/// </summary>
	enum Gender
	{
		FEMALE,
		MALE
	}
	/// <summary>
	/// 学生；
	/// </summary>
    class Student                                                   //定义类（默认为内部类）；若将此处class换为struct，可正常执行；
    {
        public string Number;                                       //定义公有字段；
        public string Name;
        public Gender Gender;
        public DateTime BirthDate;
        public string PhoneNumber;
    }
}
