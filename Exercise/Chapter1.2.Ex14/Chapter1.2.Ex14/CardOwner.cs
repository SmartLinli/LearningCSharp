using static System.Console;
using System;

namespace Chapter1_2_Ex14
{
    /// <summary>
    /// 持卡人
    /// </summary>
    public partial class CardOwner
    {
        /// <summary>
        /// 学号
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 余额
        /// </summary>
        public double Balance { get; set; }
        /// <summary>
        /// 补贴余额
        /// </summary>
        public double Allowance { get; set; }
        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="amount">金额</param>
        public void Recharge(double amount)
        {
            this.Balance += amount;
            WriteLine($"充值成功{amount}元。余额{this.Balance}元，补贴余额{this.Allowance}元。({DateTime.Now})");
            ReadLine();
        }
        /// <summary>
        /// 补贴
        /// </summary>
        /// <param name="amount">金额</param>
        public void Subsidise(double amount)
        {
            this.Allowance += amount;
            this.Allowance = this.Allowance > 100 ? 100 : this.Allowance;
            WriteLine($"补贴成功{amount}元。余额{this.Balance}元，补贴余额{this.Allowance}元。({DateTime.Now})");
            ReadLine();
        }
    }
}
