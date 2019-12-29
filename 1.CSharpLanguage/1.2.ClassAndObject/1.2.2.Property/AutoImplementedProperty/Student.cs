using System;
using static System.Console;

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
        private string _Number;
		/// <summary>
		/// 学号；
		/// </summary>
		public string Number                                        
        {
            get                                                     
            {
                return this._Number;                                
            }
            set                                                     
            {                                                       
                if (this._Number == null)                           
                {
                    this._Number = value;                           
                }
                else
                {
                    WriteLine("已有学号，不得更改！");
                }
            }
        }
		/// <summary>
		/// 姓名；
		/// </summary>
		public string Name { get; set; }                            //自动实现属性；
		/// <summary>
		/// 性别；
		/// </summary>
		public Gender Gender { get; set; }							
		/// <summary>
		/// 生日；
		/// </summary>
		public DateTime BirthDate { get; set; }
        private string _PhoneNumber;
		/// <summary>
		/// 电话；
		/// </summary>
        public string PhoneNumber
        {
            get
            {
                if (this._PhoneNumber != null)                      
                {
                    return this._PhoneNumber.Substring(0, 3) + "****" + this._PhoneNumber.Substring(7, 4);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this._PhoneNumber = value;
            }
        }
	}
}
