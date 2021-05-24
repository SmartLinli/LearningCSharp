using System;

namespace SmartLin.LearningCSharp.BridgePattern
{
    /// <summary>
    /// 书面化课程运行；
    /// </summary>
    public class CourseOperationWritten : ICourseOperation                                      //具体实现者；
    {
        /// <summary>
        /// 作业；
        /// </summary>
        public void Exercise()
        {
            Console.WriteLine("--完成配套习题，将解答过程与答案书写在作业纸上，每周一学委收齐上交。");
        }
        /// <summary>
        /// 考试；
        /// </summary>
        public void Examine()
        {
            Console.WriteLine("--在教室安排闭卷笔试。请带齐三证。");
        }
    }
}
