using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	public enum Gender
    {
        FEMALE = 0,
        MALE = 1
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
