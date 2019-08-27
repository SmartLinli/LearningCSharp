using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	/// <summary>
	/// 学生；
	/// </summary>
	public partial class Student                                                        //定义部分类；                                                
    {
        /// <summary>
        /// 电子邮件地址；
        /// </summary>
        public string Email
        {
            get;
            set;
        }
        /// <summary>
        /// 创建；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <returns>学生</returns>
        public static Student Create(string number, string name, string gender)         //定义静态方法；
        {
            if (number.Length != 10)
            {
                WriteLine("学号长度应为10位！");
                return null;
            }
            else
            {
                Student student = new Student(number, name, gender);                    //调用私有构造函数；
                return student;
            }
        }
        /// <summary>
        /// 创建；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="currentClass">班级</param>
        /// <returns>学生</returns>
        public static Student Create(string number, string name, string gender, Class currentClass)
        {
            Student student = Create(number, name, gender);                             //调用本类的静态方法；
            if (student!=null)
            {
                student.Class = currentClass;
            }
            return student;
        }
    }
}
