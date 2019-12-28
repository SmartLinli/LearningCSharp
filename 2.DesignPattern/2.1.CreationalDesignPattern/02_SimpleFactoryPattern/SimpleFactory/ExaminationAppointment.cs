using System;

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
            Console.WriteLine
                ("上机考试预约成功。\n预约人：{0}，预约考试时段：{1}～{2}。"
                , this.StudentNumber
                , this.StartTime
                , this.Endtime);
            Console.Read();
        }
    }
}
