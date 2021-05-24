using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    public class ExaminationAppointment : AbstractLaboratoryAppointment
    {
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
