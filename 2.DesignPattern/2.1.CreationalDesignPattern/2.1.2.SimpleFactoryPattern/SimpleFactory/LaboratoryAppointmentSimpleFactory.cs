using System;
using System.Collections.Generic;
using System.Reflection;

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
        /// <summary>
        /// 创建上机考试预约；
        /// </summary>
        /// <returns>机房预约</returns>
        private static LaboratoryAppointment CreateExaminationAppointment()
        {
            LaboratoryAppointment appointment = new ExaminationAppointment();
            Console.Write("预约上机考试：\n请输入预约人学号：");
            appointment.StudentNumber = Console.ReadLine();
            Console.Write("请输入预约时间：");
            appointment.StartTime = Convert.ToDateTime(Console.ReadLine());
            Console.Write("请输入预约时长（1～2小时）：");
            var hour = int.Parse(Console.ReadLine());
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
            hour = hour > 5 ? 5 : hour;
            hour = hour < 2 ? 2 : hour;
            appointment.Endtime = appointment.StartTime.AddHours(hour);
            return appointment;
        }
        /// <summary>
        /// 创建；
        /// </summary>
        /// <param name="appointmentType">预约类型</param>
        /// <returns>机房预约</returns>
        public static LaboratoryAppointment Create(string appointmentTypeName)
        {
            LaboratoryAppointment appointment = null;
            Type appointmentType =
                Assembly.GetExecutingAssembly().GetType                                     //从当前程序集中获取指定类型；
                (MethodBase.GetCurrentMethod().DeclaringType.FullName);                     //获取当前方法所在类的全名（命名空间+类名）；
            MethodInfo createAppointmentMethod =
                appointmentType.GetMethod                                                   //从指定类型中获取指定方法；
                ("Create" + appointmentTypeName + "Appointment"                             //指定方法名；
                , BindingFlags.NonPublic | BindingFlags.Static);                            //指定方法的修饰符；
            appointment =
                (LaboratoryAppointment)createAppointmentMethod.Invoke(null, null);          //调用静态方法；
            return appointment;
        }
    }
}
