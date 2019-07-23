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
    public class Student : IComparable
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
        public DateTime? BirthDate                                              //基于Nullable<T>的可空类型；
        {
            get;
            set;
        }
        /// <summary>
        /// 年龄；
        /// </summary>
        public int? Age                                                         //基于Nullable<T>的可空类型；
        {
            get
            {
                if (this.BirthDate == null)
                {
                    return null;
                }
                else
                {
                    return DateTime.Now.Year - this.BirthDate.Value.Year;       //通过Value属性访问Nullable<T>中的值；
                }
            }
        }
        private string _PhoneNumber;
        /// <summary>
        /// 电话；
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                if (this._PhoneNumber != null)
                {
                    return this._PhoneNumber.Substring(0, 3) + "****" + this._PhoneNumber.Substring(7, 4);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this._PhoneNumber = value;
            }
        }
        /// <summary>
        /// 是否与目标对象相等；
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>是否相等</returns>
        public override bool Equals(object obj)                     
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
        public override int GetHashCode()                           
        {
            return this.Number.GetHashCode();                       
        }
        /// <summary>
        /// 根据学号比较；
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>大小</returns>
        public int CompareTo(object obj)
        {
            Student otherStudent = obj as Student;
            int result = this.Number.CompareTo(otherStudent.Number);
            if (result == 0)
            {
                result = this.Name.CompareTo(otherStudent.Name);
            }
            return result;
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
