
namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 形成性评价
    /// </summary>
    public class FormativeAssessment
    {
        /// <summary>
        /// 获取形成性评价；
        /// </summary>
        /// <returns></returns>
        public static string[] All
        {
            get
            {
                return new string[]
                {
                    "课后作业",
                    "实验报告",
                    "课程设计",
                    "学习笔记",
                    "论文综述",
                    "课堂小测",
                    "小组讨论",
                    "自主学习",
                    "汇报答辩"
                };
            }
        }
    }
}
