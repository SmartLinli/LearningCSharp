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
    class Student                                                   //定义类（默认为内部类）；
    {
        public string Number;                                       //定义公有字段；
        public string Name;
        public Gender Gender;
        DateTime BirthDate;											//默认访问性为私有；
        private string PhoneNumber;									//定义私有字段；
    }
}
