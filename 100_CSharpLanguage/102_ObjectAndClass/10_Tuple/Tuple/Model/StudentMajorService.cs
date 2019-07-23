using System;
using SmartLin.LearningCSharp.ClassAndObject.Model;                                         //对项目默认命名空间以外的资源访问，可通过添加调用获得便利；

namespace SmartLin.LearningCSharp.ClassAndObject.Model                                      //向文件夹添加的类，所在命名空间默认为项目默认命名空间+文件夹路径；
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
        {
            return student.Class != null;
        }
        /// <summary>
        /// 被指定专业录取；
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="newMajor">新专业</param>
        /// <returns>结果</returns>                                                          //使用元组需要添加NuGet包System.ValueTuple
        public static (bool isSuccess, string message, string warning) EnrollByMajor(this Student student, Major newMajor)
        {                                                                                   //定义该方法的返回类型为元组，并分别定义元组的各字段的类型与名称；
            var result = (isSuccess: false, message: "", warning: "");                      //定义元组对象、各字段名称以及初始值；
            if (!student.HasClass())                                                        //调用私有静态扩展方法，实现代码复用，提高代码可读性；
            {
                Class newClass = new Class(newMajor, DateTime.Now.Year);
                student.Class = newClass;
                result.isSuccess = true;                                                    //向元组对象的字段赋值；
                result.message =
                    $"{student.Name}被{newMajor.Name}专业录取，并分配至{newClass.ShortName}班。";
            }
            else
            {
                result.warning =
                    $"{student.Name}已被{student.Class.Major.Name}专业录取，不得重复录取。";
            }
            return result;
        }
        /// <summary>
        /// 为转专业进行验证；
        /// </summary>
        /// <param name="student">学生</param>
        /// <returns>是否有效</returns>
        private static (bool isValid, string warning) ValidateForTransferToMajor(this Student student)
        {
            if (student.HasClass())
            {
                return (true, "");                                                          //直接返回元组对象；
            }
            else
            {
                return (false, $"{student.Name}尚未被任何专业录取，无法转专业。");
            }
        }
        /// <summary>
        /// 转专业；
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="newMajor">新专业</param>
        /// <param name="year">年级</param>
        public static void TransferToMajor(this Student student, Major newMajor, int year)
        {
            var validationResult = student.ValidateForTransferToMajor();
            if (validationResult.isValid)
            {
                Class newClass = new Class(newMajor, year);
                student.Class = newClass;
                Console.WriteLine
                    ("{0}已转至{1}专业，并分配至{2}班。"
                    , student.Name
                    , newMajor.Name
                    , newClass.ShortName);
            }
            else
            {
                Console.WriteLine(validationResult.warning);
            }
        }
        /// <summary>
        /// 转专业；
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="newMajor">新专业</param>
        public static void TransferToMajor(this Student student, Major newMajor)
        {

            int newClassYear = student.Class.Year + 1;
            student.TransferToMajor(newMajor, newClassYear);
        }
    }
}
