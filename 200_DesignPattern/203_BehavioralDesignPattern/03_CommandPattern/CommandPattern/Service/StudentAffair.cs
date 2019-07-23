using System;

namespace SmartLin.LearningCSharp.CommandPattern
{
    /// <summary>
    /// 学工处；
    /// </summary>
    public class StudentAffair                                              //命令接受者
    {
        /// <summary>
        /// 综合成绩；
        /// </summary>
        public void OverallScore()
        {
            Console.WriteLine("计算每名学生本学年综合成绩以及排名……\n");
        }
    }
}
