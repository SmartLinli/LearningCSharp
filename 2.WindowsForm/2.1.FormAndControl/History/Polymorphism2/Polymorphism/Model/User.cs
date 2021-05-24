using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    public enum Gender
    {
        FEMALE = 0,
        MALE = 1
    }
    public abstract class User                                              //定义抽象类；抽象类不能被实例化；        
    {
        public string Number
        {
            get;
            private set;
        }
        public string Name
        {
            get;
            private set;
        }
        public Gender Gender
        {
            get;
            private set;
        }
        public DateTime BirthDate
        {
            get;
            set;
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.BirthDate.Year;
            }
        }
        private string _PhoneNumber;
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
        public virtual void Intro()                                         //定义虚方法；虚方法可在派生类中被重写；
        {
            Console.Write("我叫{0}", this.Name);
        }
        public void SendSms(string message)                                 //定义虚方法；虚方法可在派生类中被重写；
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
        public User(string number, string name, Gender gender)
        {
            this.Number = number;
            this.Name = name;
            this.Gender = gender;
        }
    }
}
