using System;
using static System.Console;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 上机练习预约；
    /// </summary>
    public class ExerciseAppointment : LaboratoryAppointment
    {
        /// <summary>
        /// 显示结果；
        /// </summary>
        public override void ShowResult()
        {
            WriteLine
                ($"上机练习预约成功。{Environment.NewLine}" +
                 $"预约人：{this.StudentNumber}，预约时段：{this.StartTime}～{this.Endtime}。");
            Read();
        }
    }
}
