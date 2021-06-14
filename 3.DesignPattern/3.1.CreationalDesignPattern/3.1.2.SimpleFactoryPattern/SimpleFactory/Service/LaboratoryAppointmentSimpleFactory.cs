using System;
using System.Collections.Generic;
using static System.Console;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 机房预约简单工厂；
    /// </summary>
    public class LaboratoryAppointmentSimpleFactory
    {
        /// <summary>
        /// 创建上机练习预约；
        /// </summary>
        /// <returns>机房预约</returns>
        private static LaboratoryAppointment CreateExerciseAppointment()
        {
            LaboratoryAppointment appointment = new ExerciseAppointment();
            WriteLine("预约上机练习：");
            Write("请输入预约人学号：");
            appointment.StudentNumber = ReadLine();
            Write("请输入预约时间：");
            appointment.StartTime = DateTime.Parse(ReadLine());
            Write("请输入预约时长（1～3小时）：");
            var hour = int.Parse(ReadLine());
            hour = hour > 3 ? 3 : hour;
            hour = hour < 1 ? 1 : hour;
            appointment.Endtime = appointment.StartTime.AddHours(hour);
            return appointment;
        }
        /// <summary>
        /// 创建上机考试预约；
        /// </summary>
        /// <returns>机房预约</returns>
        private static LaboratoryAppointment CreateExaminationAppointment()
        {
            LaboratoryAppointment appointment = new ExaminationAppointment();
            WriteLine("预约上机考试：");
            Write("请输入预约人学号：");
            appointment.StudentNumber = ReadLine();
            Write("请输入预约时间：");
            appointment.StartTime = DateTime.Parse(ReadLine());
            Write("请输入预约时长（1～2小时）：");
            var hour = int.Parse(ReadLine());
            hour = hour > 2 ? 2 : hour;
            hour = hour < 1 ? 1 : hour;
            appointment.Endtime = appointment.StartTime.AddHours(hour);
            return appointment;
        }
        /// <summary>
        /// 创建程序竞赛训练预约；
        /// </summary>
        /// <returns>机房预约</returns>
        private static LaboratoryAppointment CreateAcmAppointment()
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
        /// <summary>
        /// 创建；
        /// Exercise：上机练习预约, Examination：上机考试预约, Acm：程序竞赛训练预约
        /// </summary>
        /// <param name="appointmentType">预约类型编号</param>
        /// <returns>机房预约</returns>
        public static LaboratoryAppointment Create(string appointmentTypeNumber)
        {
            LaboratoryAppointment appointment = null;
            switch (appointmentTypeNumber)
            {
                case "1":
                    {
                        appointment = CreateExerciseAppointment();
                    }
                    break;
                case "2":
                    {
                        appointment = CreateExaminationAppointment();
                    }
                    break;
                case "3":
                    {
                        appointment = CreateAcmAppointment();
                    }
                    break;
                default:
                    break;
            }
            return appointment;
        }
    }
}
