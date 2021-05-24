using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    public class AcmAppointment : AbstractLaboratoryAppointment
    {
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
