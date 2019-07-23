using System;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
    /// <summary>
    /// 学生；
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 学号；
        /// </summary>
        public string Number
        {
            get;
            private set;
        }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 是否与目标对象相等；
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>是否相等</returns>
        public override bool Equals(object obj)                     //重写基类object的Equals方法；
        {
            if (obj == null)                                        //若比较对象为空值，则双方不等；
            {
                return false;
            }
            if (!(obj is Student))                                  //若比较对象的类并非学生，则双方不等；
            {
                return false;
            }
            Student otherStudent = obj as Student;                  //将比较对象显式转换为学生类；
            return this.Number == otherStudent.Number;              //比较两个学生对象的学号是否相等；
        }
        /// <summary>
        /// 获取散列值；
        /// </summary>
        /// <returns>散列值</returns>
        public override int GetHashCode()                           //若对象将用作字典的键值，则在重写基类object的Equals方法后，还需重写基类object的GetHashCode方法；
        {
            return this.Number.GetHashCode();                       //返回学号的散列值；即只要两个学生对象的学号的散列值相等，则双方的键值相等；
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        public Student(string number, string name)
        {
            this.Number = number;
            this.Name = name;
        }

    }
}
