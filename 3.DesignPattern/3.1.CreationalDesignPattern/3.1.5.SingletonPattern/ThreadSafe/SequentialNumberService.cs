namespace SmartLin.LearningCSharp.SingletonPattern
{
    /// <summary>
    /// 流水号服务；
    /// </summary>
    public sealed class SequentialNumberService
    {
        /// <summary>
        /// 当前流水号；
        /// </summary>
        private int _CurrentSequentialNumber = 1;
        /// <summary>
        /// 流水号服务实例；
        /// </summary>
        public static SequentialNumberService Instance => new SequentialNumberService();
        /// <summary>
        /// 获取流水号；
        /// </summary>
        /// <returns>流水号</returns>
        public string GetSequentialNumber()
        {
            string newSequentialNumber = Instance._CurrentSequentialNumber.ToString();
            newSequentialNumber = newSequentialNumber.PadLeft(10, '0');
            Instance._CurrentSequentialNumber++;
            return newSequentialNumber;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        static SequentialNumberService()
        {
            ;
        }
    }
}
