namespace SmartLin.LearningCSharp.AdapterPattern
{
    /// <summary>
    /// 密码系统；
    /// </summary>
    public interface ICryptography
    {
        /// <summary>
        /// 计算；
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        byte[] Compute(string plainText);
    }
}
