using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    /// <summary>
    /// 学生专业服务；
    /// </summary>
    public static class StudentMajorService
    {
        /// <summary>
        /// 是否有班级；
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        private static bool HasClass(this Student student)                                  //定义私有静态方法，并实现扩展方法；
        => student.Class != null;
        /// <summary>
        /// 被指定专业录取；
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="newMajor">新专业</param>
        public static void EnrollBy(this Student student, Major newMajor)
        {
            if (student.HasClass())
            {
                WriteLine
                    ($"{student.Name}已被{student.Class.Major.Name}专业录取，不得重复录取。");
                return;
            }
            /*根据指定的新专业，创建新班级，年级则为今年；*/
            Class newClass = new Class(newMajor, DateTime.Now.Year);
            student.Class = newClass;
            WriteLine
                ($"{student.Name}被{newMajor.Name}专业录取，并分配至{newClass.ShortName}班。");
        }
        /// <summary>
        /// 为转专业进行验证；
        /// </summary>
        /// <param name="student">学生</param>
        /// <returns>是否有效</returns>
        private static bool ValidateForTransferToMajor(this Student student)
        {
            if (!student.HasClass())
            {
                WriteLine
                    ($"{student.Name}尚未被任何专业录取，无法转专业。");
            }
            return student.HasClass();
        }
        /// <summary>
        /// 转专业；
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="newMajor">新专业</param>
        /// <param name="year">年级</param>
        public static void TransferTo(this Student student, Major newMajor, int year)
        {
            if (!student.ValidateForTransferToMajor())
                return;
            /*根据指定的新专业与年级，创建新班级；*/
            Class newClass = new Class(newMajor, year);
            student.Class = newClass;
            WriteLine
                ($"{student.Name}已转至{newMajor.Name}专业，并分配至{newClass.ShortName}班。");
        }
        /// <summary>
        /// 转专业；
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="newMajor">新专业</param>
        public static void TransferTo(this Student student, Major newMajor)
        {
            if (!student.ValidateForTransferToMajor())
                return;
            /*根据指定的新专业，创建新班级，年级则比当前班级年级增加1年；*/
            int newClassYear = student.Class.Year + 1;
            student.TransferTo(newMajor, newClassYear);
        }
    }
}
