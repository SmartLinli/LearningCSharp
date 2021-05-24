using System;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 笔试；
    /// </summary>
    public class WrittenExamination : IExamination
    {
        /// <summary>
        /// 课程名称；
        /// </summary>
        public string CourseName
        {
            get;
            set;
        }
        /// <summary>
        /// 考场；
        /// </summary>
        public IExaminationRoom Room
        {
            get;
            set;
        }
        /// <summary>
        /// 监考；
        /// </summary>
        public IInvigilator Invigilator
        {
            get;
            set;
        }
        /// <summary>
        /// 显示结果；
        /// </summary>
        public void ShowResult()
        {
            Console.WriteLine("《{0}》笔试安排如下：", this.CourseName);
            Console.WriteLine("教室：{0}\t座位数：{1}", this.Room.Number, this.Room.SeatAmount);
            Console.WriteLine("监考：{0}\n", this.Invigilator.Name);
        }
    }
}
