namespace SmartLin.LearningCSharp.CommandPattern
{
    /// <summary>
    /// 财务处命令；
    /// </summary>
    public class FinancialAffairCommand : ICommand                              //定义具体命令，用于执行财务处命令；
    {
        /// <summary>
        /// 财务处；
        /// </summary>
        private FinancialAffair _FinancialAffair;                               //引用财务处对象；
        /// <summary>
        /// 执行；
        /// </summary>
        public void Execute()
        {
            this._FinancialAffair.BudgeAudit();                                 //执行实际命令；
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="financialAffair">财务处</param>
        public FinancialAffairCommand(FinancialAffair financialAffair)
        {
            this._FinancialAffair = financialAffair;
        }
    }
}
