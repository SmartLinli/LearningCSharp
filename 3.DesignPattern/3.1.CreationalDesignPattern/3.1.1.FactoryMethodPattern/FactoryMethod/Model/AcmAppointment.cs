using System;
using System.Linq;
using static System.Console;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 程序竞赛训练预约；
    /// </summary>
    public class AcmAppointment : LaboratoryAppointment
    {
        /// <summary>
        /// 显示结果；
        /// </summary>
        public override void ShowResult()
        {
            string mateStudentNumbers = "";
            this.MateStudentNumbers.ToList().ForEach(s => mateStudentNumbers += s + " ");
            WriteLine
                ($"程序竞赛训练预约成功。{Environment.NewLine}" +
                 $"预约人：{this.StudentNumber}，队友：{mateStudentNumbers}{Environment.NewLine}" +
                 $"预约训练时段：{this.StartTime}～{this.Endtime}。");
            Read();
        }
    }
}
