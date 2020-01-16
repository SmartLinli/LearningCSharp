using System;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    class Program
    {
        static void Main()
        {
            /*Exercise：上机练习预约, Examination：上机考试预约, Acm：程序竞赛训练预约*/
            LaboratoryAppointment appointment = ExerciseAppointmentFactoryMethod.Create();      //根据需要调用工厂方法，并创建产品；
            appointment.ShowResult();
            Console.Read();
        }
    }
}
