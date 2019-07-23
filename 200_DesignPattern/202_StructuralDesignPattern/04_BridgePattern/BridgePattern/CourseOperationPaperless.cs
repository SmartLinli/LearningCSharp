using System;

namespace SmartLin.LearningCSharp.BridgePattern
{
    /// <summary>
    /// 无纸化课程运行；
    /// </summary>
    public class CourseOperationPaperless : ICourseOperation                                    //具体实现者；
    {
        /// <summary>
        /// 作业；
        /// </summary>
        public void Exercise()
        {
            Console.WriteLine
                ("--完成配套习题，将代码文件上传至代码托管平台，将学习笔记发布至博客。");
        }
        /// <summary>
        /// 考试；
        /// </summary>
        public void Examine()
        {
            Console.WriteLine
                ("--在机房安排开卷上机考试。可自行拷贝文档资料，但机房屏蔽外网。请带齐三证。");
        }
    }
}
