namespace SmartLin.LearningCSharp.ProxyPattern
{
    /// <summary>
    /// 课程；
    /// </summary>
    public interface ICourse
    {
        /// <summary>
        /// 课程号；
        /// </summary>
        string Number { get; set; }
        /// <summary>
        /// 名称；
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// 学分；
        /// </summary>
        float Credit { get; set; }
        /// <summary>
        /// 更新；
        /// </summary>
        void Update();
    }
}
