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
    public class Student                                                    
    {
        private string _Number;                                     //定义私有字段，用于保存相应属性所用的数据；只能在所属的类中访问私有成员；
		public string Number                                        //定义公有属性；
        {
            get                                                     //get访问器用于读取属性；get访问器不包含任何参数；
            {
                return this._Number;                                //返回类的当前实例的相应字段；
            }
            set                                                     //set访问器用于写入属性；
            {                                                       
                this._Number = value;								//set访问器包含隐式参数value；
            }
        }
		public string Name;
		public Gender Gender;
		public DateTime BirthDate;
		public string PhoneNumber;
	}
}
