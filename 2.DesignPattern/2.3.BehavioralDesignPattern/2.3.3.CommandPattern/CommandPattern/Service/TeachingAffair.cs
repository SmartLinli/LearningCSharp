using System;

namespace SmartLin.LearningCSharp.CommandPattern
{
    /// <summary>
    /// 教务处；
    /// </summary>
    public class TeachingAffair                                             //命令接受者
    {
        /// <summary>
        /// 评教汇总；
        /// </summary>
        public void EvaluationAggregate()
        {
            Console.WriteLine("汇总统计每名教师的各课程、班级的评教得分……\n");
        }
    }
}
