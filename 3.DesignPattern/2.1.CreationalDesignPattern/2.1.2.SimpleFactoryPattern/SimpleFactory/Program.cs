using System;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    class Program
    {
        static void Main()
        {
            /*Exercise：上机练习预约, Examination：上机考试预约, Acm：程序竞赛训练预约*/
            LaboratoryAppointment appointment = 
                LaboratoryAppointmentSimpleFactory.Create("Examination");               //定义简单工厂，并创建指定的产品；
            appointment.ShowResult();
            Console.Read();
        }
    }
}
