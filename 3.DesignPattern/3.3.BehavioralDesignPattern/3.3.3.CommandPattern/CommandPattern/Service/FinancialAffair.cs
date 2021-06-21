using static System.Console;

namespace SmartLin.LearningCSharp.CommandPattern
{
    /// <summary>
    /// 财务处；
    /// </summary>
    public class FinancialAffair                                            //命令接受者；
    {
        /// <summary>
        /// 预算审核；
        /// </summary>
        public void BudgeAudit()
        {
            WriteLine("审核下学年各项教学经费预算……");
        }
    }
}
