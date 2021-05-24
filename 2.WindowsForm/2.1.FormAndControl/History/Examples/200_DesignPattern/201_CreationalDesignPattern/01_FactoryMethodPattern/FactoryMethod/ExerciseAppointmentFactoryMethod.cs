using System;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 上机练习预约工厂方法；
    /// </summary>
    public class ExerciseAppointmentFactoryMethod
    {
        /// <summary>
        /// 创建；
        /// </summary>
        /// <returns>机房预约</returns>
        public static LaboratoryAppointment Create()
        {
            LaboratoryAppointment appointment = new ExerciseAppointment();
            Console.Write("预约上机练习：\n请输入预约人学号：");
            appointment.StudentNumber = Console.ReadLine();
            Console.Write("请输入预约时间：");
            appointment.StartTime = Convert.ToDateTime(Console.ReadLine());
            Console.Write("请输入预约时长（1～3小时）：");
            var hour = int.Parse(Console.ReadLine());
            hour = hour > 3 ? 3 : hour;
            hour = hour < 1 ? 1 : hour;
            appointment.Endtime = appointment.StartTime.AddHours(hour);
            return appointment;
        }
    }
}
