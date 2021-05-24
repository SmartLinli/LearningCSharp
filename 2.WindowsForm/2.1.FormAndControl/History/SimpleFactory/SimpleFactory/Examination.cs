using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    public class Examination:ILaboratory
    {
        public DayOfWeek MaintainWeekDay
        {
            get;
            set;
        }
        public int AvailableAmount
        {
            get;
            set;
        }
    }
}
