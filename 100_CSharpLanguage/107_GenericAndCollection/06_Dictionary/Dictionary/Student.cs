using System;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 性别；
    /// </summary>
    public enum Gender
    {
        FEMALE = 0,
        MALE = 1
    }
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
        /// 性别；
        /// </summary>
        public Gender Gender
        {
            get;
            set;
        }
        /// <summary>
        /// 生日；
        /// </summary>
        public DateTime? BirthDate                                              
        {
            get;
            set;
        }
        /// 是否与目标对象相等；
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>是否相等</returns>
        public override bool Equals(object obj)                                 //字典要求元素重写Equals方法，用于比较键；                 
        {
            if (obj == null)                                        
            {
                return false;
            }
            if (!(obj is Student))                                  
            {
                return false;
            }
            Student otherStudent = obj as Student;                  
            return this.Number == otherStudent.Number;              
        }
        /// <summary>
        /// 获取散列值；
        /// </summary>
        /// <returns>散列值</returns>
        public override int GetHashCode()                                       //字典要求元素重写GetHashCode方法，确保若2个元素的键相等，则散列值也相等（即元素的位置相等）；             
        {   
            return this.Number.GetHashCode();                       
        }        
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Student(string number, string name, Gender gender)
        {
            this.Number = number;
            this.Name = name;
            this.Gender = gender;
            this.BirthDate = null;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="birthDate">生日</param>
        public Student(string number, string name, Gender gender, DateTime birthDate)
            : this(number, name, gender)
        {
            this.BirthDate = birthDate;
        }
    }
}
