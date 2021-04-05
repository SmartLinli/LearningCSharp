using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public static class StudentMajorService                                                 //定义静态类；扩展方法必须定义在静态类中；
    {
        private static bool HasClass(this Student student)                                  //定义私有静态方法，并通过首个参数定义，对其所属类实现扩展方法；
        {
            return student.Class != null;
        }
        public static void EnrollBy(this Student student, Major newMajor)              //定义公有静态方法，实现扩展方法；
        {
            if (student.HasClass())                                                         //调用私有静态扩展方法，实现代码复用，提高代码可读性；
            {
                WriteLine($"{student.Name}已被{student.Class.Major.Name}专业录取，不得重复录取。");
                return;
            }
            Class newClass = new Class(newMajor, DateTime.Now.Year);
            student.Class = newClass;
            WriteLine($"{student.Name}被{newMajor.Name}专业录取，并分配至{newClass.ShortName}班。");
        }
        private static bool ValidateForTransferToMajor(this Student student)
        {
            if (!student.HasClass())
            {
                WriteLine($"{student.Name}尚未被任何专业录取，无法转专业。");
            }
            return student.HasClass();
        }
        public static void TransferTo(this Student student, Major newMajor, int year)  //公有静态扩展方法（重载1）
        {
            if (!student.ValidateForTransferToMajor())                                      //调用私有静态扩展方法，实现代码复用；
                return;
            Class newClass = new Class(newMajor, year);
            student.Class = newClass;
            WriteLine($"{student.Name}已转至{newMajor.Name}专业，并分配至{newClass.ShortName}班。");
        }
        public static void TransferTo(this Student student, Major newMajor)            //公有静态扩展方法（重载2）
        {
            if (!student.ValidateForTransferToMajor())
                return;
            int newClassYear = student.Class.Year + 1;
            student.TransferTo(newMajor, newClassYear);                                //调用另一重载方法，实现代码复用；
        }
    }
}
