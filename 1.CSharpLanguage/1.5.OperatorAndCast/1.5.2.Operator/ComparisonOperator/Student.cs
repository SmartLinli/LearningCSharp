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
        /// 判断相等；
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>是否相等</returns>
        public override bool Equals(object obj)                                         //重写基类object的Equals方法；
        {
            if (obj == null)                                                            //若比较对象为空值，则双方不等；
            {
                return false;
            }
            if (!(obj is Student))                                                      //若比较对象的类并非学生，则双方不等；
            {
                return false;
            }
            Student otherStudent = obj as Student;                                      //将比较对象显式转换为学生类；
            return this.Number == otherStudent.Number;                                  //比较两个学生对象的学号是否相等；
        }
        /// <summary>
        /// 获取散列值；
        /// </summary>
        /// <returns>散列值</returns>
        public override int GetHashCode()                                               //若对象将用作字典的键值，则在重写基类object的Equals方法后，还需重写基类object的GetHashCode方法；
        {
            return this.Number.GetHashCode();                                           //返回学号的散列值；即只要两个学生对象的学号的散列值相等，则双方的键值相等；
        }
		/// <summary>
		/// 判断相等；
		/// </summary>
		/// <param name="student">学生</param>
		/// <param name="otherStudent">另一学生</param>
		/// <returns>是否相等</returns>
		public static bool operator ==(Student student, Student otherStudent)           //重载比较运算符==；比较运算符应成对重载，故还需重载!=；另外还需重写Equals与GetHashCode方法；
		{
			if (ReferenceEquals(student, otherStudent))                                 //调用基类object的ReferenceEquals方法，判断双方的引用地址是否相等（包括双方均为空值的情况）；
			{
				return true;
			}
			if (student is null || otherStudent is null)								//判断双方是否为空；若直接使用=运算符与null比较，将导致栈溢出；
			{
				return false;
			}
			return student.Number == otherStudent.Number;                               //比较两个学生对象的学号是否相等；
		}
        /// <summary>
        /// 判断不等；
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="otherStudent">另一学生</param>
        /// <returns>是否不等</returns>
        public static bool operator !=(Student student, Student otherStudent)           //重载比较运算符!=；比较运算符应成对重载；
        {
            return !(student == otherStudent);                                          //调用比较运算符==的重载；
        }
        /// <summary>
        /// 构造函数；
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
