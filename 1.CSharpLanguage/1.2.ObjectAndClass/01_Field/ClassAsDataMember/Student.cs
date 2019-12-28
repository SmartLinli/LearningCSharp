using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public enum Gender
    {
        FEMALE = 0,
        MALE = 1
    }
    public class Student                                            //定义公有类；                      
    {
        public string Number;                                       
        public string Name;
        public Gender Gender;
        public DateTime BirthDate;
        public string PhoneNumber;
        public Class Class;                                         //类的数据成员可以是其它类的对象；
    }
}
