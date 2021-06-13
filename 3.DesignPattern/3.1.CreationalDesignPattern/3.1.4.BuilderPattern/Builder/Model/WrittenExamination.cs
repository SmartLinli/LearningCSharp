using System;
using static System.Console;

namespace SmartLin.LearningCSharp.BuilderPattern
{

    /// <summary>
    /// 笔试；
    /// </summary>
    public class WrittenExamination : IExamination
    {
        /// <summary>
        /// 课程；
        /// </summary>
        public Course Course { get; set; }
        /// <summary>
        /// 考场；
        /// </summary>
        public ClassRoom Room { get; set; }
        /// <summary>
        /// 监考；
        /// </summary>
        public Faculty Invigilator { get; set; }
        /// <summary>
        /// 显示结果；
        /// </summary>
        public void ShowResult()
        {
            WriteLine
                ($"{Environment.NewLine}《{this.Course.Name}》笔试安排如下：" +
                 $"教室：{this.Room.Number}\t座位数：{this.Room.SeatAmount}" +
                 $"{(this.Invigilator == null ? "【无人监考  诚信考试】" : $"监考：{ this.Invigilator.Name}")}");
        }
    }
}
