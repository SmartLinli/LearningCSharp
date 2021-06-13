using System;
using static System.Console;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 上机考试预约；
    /// </summary>
    public class ExaminationAppointment : LaboratoryAppointment
    {
        /// <summary>
        /// 显示结果；
        /// </summary>
        public override void ShowResult()
        {
            WriteLine
                ($"上机考试预约成功。{Environment.NewLine }" +
                 $"预约人：{this.StudentNumber}，预约考试时段：{this.StartTime}～{this.Endtime}。");
            Read();
        }
    }
}
