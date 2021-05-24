using System;

namespace SmartLin.LearningCSharp.Inheritance
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
    /// 用户；
    /// </summary>
    public abstract class User                                                      //定义抽象类：
    {
        /// <summary>
        /// 编号；
        /// </summary>
        public string Number
        {
            get;
            private set;                                                            //派生类无法访问基类的私有成员；
        }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name
        {
            get;
            private set;
        }
        /// <summary>
        /// 性别；
        /// </summary>
        public Gender Gender
        {
            get;
            private set;
        }
        /// <summary>
        /// 生日；
        /// </summary>
        public DateTime BirthDate
        {
            get;
            set;                                                          
        }
        /// <summary>
        /// 年龄；
        /// </summary>
        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.BirthDate.Year;
            }
        }
        private string _PhoneNumber;
        /// <summary>
        /// 手机号码；
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
        /// 介绍；
        /// </summary>
        public virtual void Intro()                                                 //定义虚方法；虚方法在派生类中既可继承，亦可被重写；
        {
            Console.Write("我叫{0}", this.Name);
        }
        /// <summary>
        /// 发送短信；
        /// </summary>
        /// <param name="message">消息</param>
        public virtual void SendSms(string message)                                 //定义虚方法；虚方法在派生类中既可继承，亦可被重写；
        {
            if (this._PhoneNumber != null)
            {
                Console.WriteLine("发送短信至用户手机{0}：{1}\n", this.PhoneNumber, message);
            }
            else
            {
                Console.WriteLine("用户尚未登记手机号。\n");
            }
        }
        /// <summary>
        /// 构造函数 
        /// </summary>
        /// <param name="number">编号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public User(string number, string name, Gender gender)                      
        {
            this.Number = number;
            this.Name = name;
            this.Gender = gender;
        }
    }
}
