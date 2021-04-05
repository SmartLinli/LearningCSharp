using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	public class Student
	{
		public string Name { get; set; }
		public Class Class { get; private set; }                            //将set访问器的访问性定义为私有，实现只读属性；
		private bool HasClass                                               
		=>	this.Class != null;
		private bool ValidateTransferToMajor()								//定义私有方法；
        {
            if (!this.HasClass)
            {
				WriteLine($"{this.Name}尚未被任何专业录取，无法转专业。");
            }
            return this.HasClass;
        }
        public void Intro()                                                 
        =>	WriteLine
                ($"我叫{this.Name}" +
                 $"{(this.HasClass ? $"，来自{this.Class.ShortName}" : "")}。");
        public void EnrollBy(Major newMajor)
        {
            if (this.HasClass)                                              
            {
				WriteLine($"{this.Name}已被{this.Class.Major.Name}专业录取，不得重复录取。");
				return;
            }
            Class newClass = new Class();
            newClass.Year = DateTime.Now.Year;
            newClass.Major = newMajor;
            this.Class = newClass;											//访问属性的私有访问器；实现封装；
			WriteLine($"{this.Name}被{newMajor.Name}专业录取，并分配至{newClass.ShortName}班。");
        }
		public void TransferTo(Major newMajor, int year)               //定义公有方法（重载1）
		{
			if (!this.ValidateTransferToMajor())							//调用私有方法，提高代码复用；
				return;
            Class newClass = new Class();
            newClass.Major = newMajor;
            newClass.Year = year;
            this.Class = newClass;
			WriteLine($"{this.Name}已转至{newMajor.Name}专业，并分配至{newClass.ShortName}班。");
        }
		public void TransferTo(Major newMajor)                         //定义公有方法（重载2）
		{
			if (!this.ValidateTransferToMajor())							//调用私有方法，提高代码复用；
				return;
			int newClassYear = this.Class.Year + 1;
            this.TransferTo(newMajor, newClassYear);					//调用另一重载方法，提高代码复用；
        }
    }
}
