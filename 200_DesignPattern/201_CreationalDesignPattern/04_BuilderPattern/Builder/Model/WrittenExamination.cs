using System;

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
        public Course Course
        {
            get;
            set;
        }
        /// <summary>
        /// 考场；
        /// </summary>
        public ClassRoom Room
        {
            get;
            set;
        }
        /// <summary>
        /// 监考；
        /// </summary>
        public Faculty Invigilator
        {
            get;
            set;
        }
        /// <summary>
        /// 显示结果；
        /// </summary>
        public void ShowResult()
        {
            Console.WriteLine
                ("\n《{0}》笔试安排如下："
                , this.Course.Name);
            Console.WriteLine
                ("教室：{0}\t座位数：{1}"
                , this.Room.Number
                , this.Room.SeatAmount);
            Console.WriteLine
                (this.Invigilator == null ?
                "【无人监考  诚信考试】"
                : string.Format
                    ("监考：{0}\n"
                    , this.Invigilator.Name));
        }
    }
}
