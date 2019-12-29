﻿using System;

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
        public Student(string number, string name, Gender gender)                       //定义构造函数（重载1）；
        {
            this.Number = number;														
            this.Name = name;
            this.Gender = gender;
        }
        public Student(string number, string name, Gender gender, Class currentClass)   //定义构造函数（重载2）；
            : this(number, name, gender)                                                
        {                                                                               
            this.Class = currentClass;
        }
    }
}
