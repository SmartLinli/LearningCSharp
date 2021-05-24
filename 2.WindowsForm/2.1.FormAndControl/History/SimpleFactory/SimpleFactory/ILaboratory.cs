using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    public interface ILaboratory
    {
        DayOfWeek MaintainWeekDay
        {
            get;
            set;
        }
        int AvailableAmount
        {
            get;
            set;
        }
    }
}
