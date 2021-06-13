using System;
using static System.Console;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 上机考试预约工厂方法；
    /// </summary>
    public class ExaminationAppointmentFactoryMethod
    {        
        /// <summary>
        /// 创建；
        /// </summary>
        /// <returns>机房预约</returns>
        public static LaboratoryAppointment Create()
        {
            LaboratoryAppointment appointment = new ExaminationAppointment();
            Write($"预约上机考试：{Environment.NewLine}请输入预约人学号：");
            appointment.StudentNumber = ReadLine();
            Console.Write("请输入预约时间：");
            appointment.StartTime = Convert.ToDateTime(ReadLine());
            Console.Write("请输入预约时长（1～2小时）：");
            var hour = int.Parse(ReadLine());
            hour = hour > 2 ? 2 : hour;
            hour = hour < 1 ? 1 : hour;
            appointment.Endtime = appointment.StartTime.AddHours(hour);
            return appointment;
        }
    }
}
