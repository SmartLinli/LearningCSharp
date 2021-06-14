using System;
using static System.Console;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    class Program
    {
        static void Main()
        {
            Write
                ($"欢迎使用机房预约{Environment.NewLine}" +
                 $"1、上机练习预约{Environment.NewLine}" +
                 $"2、上机考试预约{Environment.NewLine}" +
                 $"3、程序竞赛训练预约{Environment.NewLine}" +
                  "请输入序号：");
            string appointmentTypeNumber = ReadLine();
            var appointment =
                LaboratoryAppointmentSimpleFactory.Create(appointmentTypeNumber);               //定义简单工厂，并创建指定的产品；
            appointment.ShowResult();
            Read();
        }
    }
}
