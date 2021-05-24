using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    public class ExerciseAppointment : AbstractLaboratoryAppointment
    {
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
