using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public class Student
    {
        public string Name { get; set; }
        public Class Class { get; private set; }
        private bool HasClass
        =>  this.Class != null;
        public void EnrollBy(Class newClass)                                //定义公有方法（重载1）
        {
            if (this.HasClass)
            {
                WriteLine($"{this.Name}已被{this.Class.Major.Name}专业录取，不得重复录取。");
                return;
            }
            this.Class = newClass;
            WriteLine($"{this.Name}被{newClass.Major.Name}专业录取，并分配至{newClass.ShortName}班。");
        }
        public void EnrollBy(Major newMajor)                                //定义公有方法（重载2）
        {
            Class newClass = new Class();
            newClass.Year = DateTime.Now.Year;
            newClass.Major = newMajor;
            this.EnrollBy(newClass);
        }
        public void TransferTo(Major newMajor, int year)                    //定义公有方法（重载1）
        {
            if (!this.HasClass)
            {
                WriteLine($"{this.Name}尚未被任何专业录取，无法转专业。");
                return;
            }
            Class newClass = new Class();
            newClass.Major = newMajor;
            newClass.Year = year;
            this.Class = newClass;
            WriteLine($"{this.Name}已转至{newMajor.Name}专业，并分配至{newClass.ShortName}班。");
        }
        public void TransferTo(Major newMajor)                              //定义公有方法（重载2）
        {
            int newClassYear = this.Class.Year + 1;
            this.TransferTo(newMajor, newClassYear);					    //调用另一重载方法，提高代码复用；
        }
    }
}
