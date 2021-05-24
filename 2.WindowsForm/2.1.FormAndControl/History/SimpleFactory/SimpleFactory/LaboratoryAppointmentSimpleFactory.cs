using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    public class LaboratoryAppointmentSimpleFactory
    {
        private static AbstractLaboratoryAppointment CreateExerciseAppointment()
        {
            AbstractLaboratoryAppointment appointment = new ExerciseAppointment();
            Console.Write("预约上机练习：\n请输入预约人学号：");
            appointment.StudentNumber = Console.ReadLine();
            Console.Write("请输入预约时间：");
            appointment.StartTime = Convert.ToDateTime(Console.ReadLine());
            Console.Write("请输入预约时长（1～3小时）：");
            var hour = int.Parse(Console.ReadLine());
            hour = hour > 3 ? 3 : hour;
            appointment.Endtime = appointment.StartTime.AddHours(hour);
            return appointment;
        }
        private static AbstractLaboratoryAppointment CreateExaminationAppointment()
        {
            AbstractLaboratoryAppointment appointment = new ExaminationAppointment();
            Console.Write("预约上机考试：\n请输入预约人学号：");
            appointment.StudentNumber = Console.ReadLine();
            Console.Write("请输入预约时间：");
            appointment.StartTime = Convert.ToDateTime(Console.ReadLine());
            Console.Write("请输入预约时长（1～2小时）：");
            var hour = int.Parse(Console.ReadLine());
            hour = hour > 2 ? 2 : hour;
            appointment.Endtime = appointment.StartTime.AddHours(hour);
            return appointment;
        }
        private static AbstractLaboratoryAppointment CreateAcmAppointment()
        {
            AbstractLaboratoryAppointment appointment = new AcmAppointment();
            Console.Write("预约程序竞赛训练：\n请输入预约人学号：");
            appointment.StudentNumber = Console.ReadLine();
            appointment.MateStudentNumbers = new List<string>();
            while (true)
            {
                Console.Write("请输入队友学号：");
                var intput = Console.ReadLine();
                if (intput == "")
                {
                    break;
                }
                else
                {
                    appointment.MateStudentNumbers.Add(intput);
                }
            }
            Console.Write("请输入预约时间：");
            appointment.StartTime = Convert.ToDateTime(Console.ReadLine());
            Console.Write("请输入预约时长（2～5小时）：");
            var hour = int.Parse(Console.ReadLine());
            hour = hour < 2 ? 2 : hour;
            hour = hour > 5 ? 5 : hour;
            appointment.Endtime = appointment.StartTime.AddHours(hour);
            return appointment;
        }
        public static AbstractLaboratoryAppointment Create(string appointmentType)
        {
            AbstractLaboratoryAppointment appointment = null;
            appointmentType = appointmentType.ToLower();
            switch (appointmentType)
            {
                case "exercise":
                    {
                        appointment = CreateExerciseAppointment();
                    }
                    break;
                case "examination":
                    {
                        appointment = CreateExaminationAppointment();
                    }
                    break;
                case "acm":
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
