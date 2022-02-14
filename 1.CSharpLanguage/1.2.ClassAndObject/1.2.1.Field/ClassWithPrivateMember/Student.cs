using System;
namespace SmartLin.LearningCSharp.ClassAndObject
{
    enum Gender
    {
        FEMALE,
        MALE 
    }
    class Student                                                   //定义类（默认访问性为内部）；
    {
        public string Number;                                       //定义公有字段；
        public string Name;
        public Gender Gender;
        DateTime BirthDate;											//默认访问性为私有；
        private string PhoneNumber;									//定义私有字段；
    }
}
