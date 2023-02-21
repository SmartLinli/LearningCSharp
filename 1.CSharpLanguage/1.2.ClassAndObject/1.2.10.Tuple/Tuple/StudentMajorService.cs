using System;

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
        private static bool HasClass(this Student student)
        =>  student.Class != null;
        /// <summary>
        /// 被指定专业录取；
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="newMajor">新专业</param>
        /// <returns>结果</returns>                                                          //使用元组需要添加NuGet包System.ValueTuple
        public static (bool IsSuccess, string Message, string Warning) EnrollBy(this Student student, Major newMajor)
        {                                                                                   //定义该方法的返回类型为元组，并分别定义元组的各字段的类型与名称；
            var result = (IsSuccess: false, Message: "", Warning: "");                      //定义元组对象、各字段名称以及初始值；
            if (student.HasClass())                                                         //调用私有静态扩展方法，实现代码复用，提高代码可读性；
            {
                result.Warning =
                    $"{student.Name}已被{student.Class.Major.Name}专业录取，不得重复录取。";
                return result;
            }
            Class newClass = new Class(newMajor, DateTime.Now.Year);
            student.Class = newClass;
            result.IsSuccess = true;                                                        //向元组对象的字段赋值；
            result.Message =
                $"{student.Name}被{newMajor.Name}专业录取，并分配至{newClass.ShortName}班。";
            return result;
        }
    }
}
