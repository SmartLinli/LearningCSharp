using System;
using System.Collections.Generic;
using static System.Console;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 程序竞赛训练预约工厂方法；
    /// </summary>
    public class AcmAppointmentFactoryMethod
    {
        /// <summary>
        /// 创建；
        /// </summary>
        /// <returns>机房预约</returns>
        public static LaboratoryAppointment Create()
        {
            LaboratoryAppointment appointment = new AcmAppointment();
            WriteLine("预约程序竞赛训练：");
            Write("请输入预约人学号：");
            appointment.StudentNumber = ReadLine();
            appointment.MateStudentNumbers = new List<string>();
            while (true)
            {
                Write("请输入队友学号：");
                var intput = ReadLine();
                if (intput == "")
                {
                    break;
                }
                appointment.MateStudentNumbers.Add(intput);
            }
            Write("请输入预约时间：");
            appointment.StartTime = DateTime.Parse(Console.ReadLine());
            Write("请输入预约时长（2～5小时）：");
            var hour = int.Parse(Console.ReadLine());
            hour = hour > 5 ? 5 : hour;
            hour = hour < 2 ? 2 : hour;
            appointment.Endtime = appointment.StartTime.AddHours(hour);
            return appointment;
        }
    }
}
