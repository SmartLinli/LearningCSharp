using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    public abstract class AbstractLaboratoryAppointment
    {
        public string StudentNumber
        {
            get;
            set;
        }
        public List<string> MateStudentNumbers
        {
            get;
            set;
        }
        public DateTime StartTime
        {
            get;
            set;
        }
        public DateTime Endtime
        {
            get;
            set;
        }
        public abstract void ShowResult();
    }
}