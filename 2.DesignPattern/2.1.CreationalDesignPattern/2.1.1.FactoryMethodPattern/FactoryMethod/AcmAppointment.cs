using System;
using System.Linq;

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
            this.MateStudentNumbers.ToList<string>().ForEach(s => mateStudentNumbers += s + " ");
            Console.WriteLine
                ("程序竞赛训练预约成功。\n预约人：{0}，队友：{1}\n预约训练时段：{2}～{3}。"
                , this.StudentNumber
                , mateStudentNumbers
                , this.StartTime
                , this.Endtime);
            Console.Read();
        }
    }
}
