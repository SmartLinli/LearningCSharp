using System;
namespace SmartLin.LearningCSharp.ClassAndObject
{
	enum Gender
	{
		FEMALE,
		MALE
	}
    class Student                                                   //定义类（默认为内部类）；若将此处class换为struct，可正常执行；
    {
        public string Number;                                       //定义公有字段；
        public string Name;
        public Gender Gender;
        public DateTime BirthDate;
        public string PhoneNumber;
    }
}
