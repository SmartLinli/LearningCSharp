
namespace SmartLin.LearningCSharp.StrategyPattern
{
    /// <summary>
    /// 加密器；
    /// </summary>
    public interface ICrypto
    {
        /// <summary>
        /// 加密；
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        string Encrypt(string plainText);
    }
}
