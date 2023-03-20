using System;
using static System.Console;

namespace Chapter1_2_Ex14
{
    /// <summary>
    /// 持卡人
    /// </summary>
    public partial class CardOwner
    {
        /// <summary>
        /// 大额消费是否需要密码
        /// </summary>
        public bool IsPasswordNeeded { get; set; }
        /// <summary>
        /// 大额消费上限
        /// </summary>
        public double ConsumptionLimit { get; set; }
        /// <summary>
        /// 每日消费上限
        /// </summary>
        public double DailyConsumptionLimit { get; set; }
        /// <summary>
        /// 每日消费累计
        /// </summary>
        private double DailyConsumptionSummary { get; set; }
        /// <summary>
        /// 上次消费时间
        /// </summary>
        private DateTime LastConsumptionDate { get; set; }
        /// <summary>
        /// 是否当日首次消费
        /// </summary>
        private bool IsFirstConsumption => (DateTime.Now - this.LastConsumptionDate).Days > 0;
        /// <summary>
        /// 检查余额与补贴余额是否足够消费
        /// </summary>
        /// <param name="amount">金额</param>
        /// <returns>余额是否足够</returns>
        private bool CheckBalance(double amount)
        {
            return (this.Allowance + this.Balance) >= amount;
        }
        /// <summary>
        /// 检查今日消费累计是否低于每日消费上限
        /// </summary>
        /// <param name="amount">金额</param>
        /// <returns>是否低于上限</returns>
        private bool CheckDailyConsumptionSummary(double amount)
        {
            if (this.IsFirstConsumption)
            {
                return amount < this.DailyConsumptionLimit;
            }
            else
            {
                return (amount + this.DailyConsumptionSummary) < this.DailyConsumptionLimit;
            }
        }
        /// <summary>
        /// 检查单笔消费是否低于大额消费上限
        /// </summary>
        /// <param name="amount">金额</param>
        /// <returns>是否达到上限</returns>
        private bool CheckConsumptionLimit(double amount)
        {
            return amount < this.ConsumptionLimit;
        }
        /// <summary>
        /// 验证大额消费密码
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        private bool CheckPassword()
        {
            if (!this.IsPasswordNeeded)
            {
                return true;
            }
            Write("请输入密码：");
            string password = ReadLine();
            return this.Password == password;
        }
        /// <summary>
        /// 扣款
        /// </summary>
        /// <param name="amount">金额</param>
        private void Charge(double amount)
        {
            this.Allowance -= amount;
            if (this.Allowance > 0)
            {
                return;
            }
            this.Balance += this.Allowance;
            this.Allowance = 0;
        }
        /// <summary>
        /// 记录每日消费累计
        /// </summary>
        /// <param name="amount"></param>
        private void RecordDailyConsumption(double amount)
        {
            if (this.IsFirstConsumption)
            {
                this.DailyConsumptionSummary = amount;
            }
            else
            {
                this.DailyConsumptionSummary += amount;
            }
            this.LastConsumptionDate = DateTime.Now;
        }
        /// <summary>
        /// 消费
        /// </summary>
        /// <param name="amount">金额</param>
        public void Consume(double amount)
        {
            if (!this.CheckBalance(amount))
            {
                WriteLine("余额不足！\n");
                return;
            }
            if (!this.CheckDailyConsumptionSummary(amount))
            {
                WriteLine("本次消费将导致今日消费累计超过每日消费上限！\n");
                return;
            }
            if (!this.CheckConsumptionLimit(amount) && !this.CheckPassword())
            {
                WriteLine("密码有误！\n");
                return;
            }
            this.Charge(amount);
            this.RecordDailyConsumption(amount);
            WriteLine($"支付成功{amount}元。余额{this.Balance}元，补贴余额{this.Allowance}元。({DateTime.Now})");
            ReadLine();
        }
    }
}