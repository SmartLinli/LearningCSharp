using System;

namespace SmartLin.LearningCSharp.ObserverPattern
{
    /// <summary>
    /// 教职工；
    /// </summary>
    public class Faculty
    {
        /// <summary>
        /// 工号；
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
        /// 构造函数；
        /// </summary>
        /// <param name="number">工号</param>
        /// <param name="name">姓名</param>
        public Faculty(string number, string name)
        {
            this.Number = number;
            this.Name = name;
        }                                            
    }
}
