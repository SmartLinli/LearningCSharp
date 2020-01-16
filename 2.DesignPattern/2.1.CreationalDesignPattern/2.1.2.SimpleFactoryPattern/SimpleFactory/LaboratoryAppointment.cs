using System;
using System.Collections.Generic;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 机房预约；
    /// </summary>
    public abstract class LaboratoryAppointment
    {
        /// <summary>
        /// 预约人学号；
        /// </summary>
        public string StudentNumber
        {
            get;
            set;
        }
        /// <summary>
        /// 同学学号；
        /// </summary>
        public List<string> MateStudentNumbers
        {
            get;
            set;
        }
        /// <summary>
        /// 起始时间；
        /// </summary>
        public DateTime StartTime
        {
            get;
            set;
        }
        /// <summary>
        /// 结束时间；
        /// </summary>
        public DateTime Endtime
        {
            get;
            set;
        }
        /// <summary>
        /// 显示结果；
        /// </summary>
        public abstract void ShowResult();
    }
}