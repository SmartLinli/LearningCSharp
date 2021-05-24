using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    class Program
    {
        static void Main()
        {
            string[] type = { "Exercise", "Examination", "ACM" };
            AbstractLaboratoryAppointment appointment = LaboratoryAppointmentSimpleFactory.Create("acm");
            appointment.ShowResult();
            Console.Read();
        }
    }
}
