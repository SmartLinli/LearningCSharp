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
        private string _Number;
		public string Number
		{
			get
			{
				return this._Number;
			}
			set
			{
				if (this._Number != null)
				{
					WriteLine("已有学号，不得更改！");
					return;
				}
				this._Number = value;
			}
		}
		public string Name { get; set; }                            //自动实现属性；
		public Gender Gender { get; set; }							
		public DateTime BirthDate { get; set; }
        private string _PhoneNumber;
        public string PhoneNumber
		{
			get
			{
				if (this._PhoneNumber != null)                      
				{
					return this._PhoneNumber.Substring(0, 3) + "****" + this._PhoneNumber.Substring(7, 4);
				}
				return null;
			}
			set
			{
				this._PhoneNumber = value;
			}
		}
	}
}
