
namespace SmartLin.LearningCSharp.SingletonPattern
{
    /// <summary>
    /// 流水号服务；
    /// </summary>
    public sealed class SequentialNumberService                                             //防止该类被继承；
    {
        /// <summary>
        /// 当前流水号；
        /// </summary>
        private static int _CurrentSequentialNumber = 1;                                    //静态成员全局唯一；                     
        /// <summary>
        /// 获取流水号；
        /// </summary>
        /// <returns>流水号</returns>
        public static string GetSequentialNumber()
        {
            string newSequentialNumber = _CurrentSequentialNumber.ToString();
            newSequentialNumber = newSequentialNumber.PadLeft(10, '0');
            _CurrentSequentialNumber++;
            return newSequentialNumber;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        private SequentialNumberService()                                                   //防止该类被实例化；
        {
            ;
        }
    }

}
