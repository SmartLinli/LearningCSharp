using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public static class StudentMajorService                                                 //定义静态类；
    {
        private static bool HasClass(this Student student)                                  //定义私有静态方法，并实现扩展方法；
        {
            return student.Class != null;
        }
        public static void EnrollByMajor(this Student student, Major newMajor)              //定义公有静态方法，并实现扩展方法；
        {
            if (!student.HasClass())                                                        //调用私有静态扩展方法，实现代码复用，提高代码可读性；
            {
                Class newClass = new Class(newMajor, DateTime.Now.Year);
                student.Class = newClass;
                Console.WriteLine
                    ("{0}被{1}专业录取，并分配至{2}班。"
                    , student.Name
                    , newMajor.Name
                    , newClass.ShortName);
            }
            else
            {
                Console.WriteLine
                    ("{0}已被{1}专业录取，不得重复录取。"
                    , student.Name
                    , student.Class.Major.Name);
            }
        }
        private static bool ValidateForTransferToMajor(this Student student)                           
        {
            if (student.HasClass())
            {
                return true;
            }
            else
            {
                Console.WriteLine
                    ("{0}尚未被任何专业录取，无法转专业。"
                    , student.Name);
                return false;
            }
        }
        public static void TransferToMajor(this Student student, Major newMajor, int year)  //公有静态扩展方法（重载1）
        {
            if (student.ValidateForTransferToMajor())                                       //调用私有静态扩展方法，实现代码复用；
            {
                Class newClass = new Class(newMajor, year);
                student.Class = newClass;
                Console.WriteLine
                    ("{0}已转至{1}专业，并分配至{2}班。"
                    , student.Name
                    , newMajor.Name
                    , newClass.ShortName);
            }
        }
        public static void TransferToMajor(this Student student, Major newMajor)            //公有静态扩展方法（重载2）
        {
            if (student.ValidateForTransferToMajor())
            {
                int newClassYear = student.Class.Year + 1;
                student.TransferToMajor(newMajor, newClassYear);                            //调用另一重载方法，实现代码复用；
            }
        }
    }
}
