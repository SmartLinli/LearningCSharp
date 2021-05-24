using System;

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
            Console.WriteLine
                ("上机练习预约成功。\n预约人：{0}，预约时段：{1}～{2}。"
                , this.StudentNumber
                , this.StartTime
                , this.Endtime);
            Console.Read();
        }
    }
}
