using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public enum LearningStatus
    {
        Normal = 0,
        Retaking = 1,
        Following = 2
    }
    public class LearningTask
    {

        public string Number
        {
            get;
            set;
        }
        public Faculty Faculty
        {
            get;
            set;
        }
        public Course Course
        {
            get;
            set;
        }
        public LearningStatus Status
        {
            get;
            set;
        }
        //public decimal FinalScore
        //{
        //    get;
        //    set;
        //}
        //public string GetFinalScoreResult()
        //{
        //    string result = 
        //        this.Rate.HasRated ? this.FinalScore.ToString() : this.Rate.RateStatus;
        //    return result;
        //}        
        public LearningTask(string number, Faculty faculty, Course course,LearningStatus status)
        {
            this.Number = number;
            this.Faculty = faculty;
            this.Course = course;
            this.Status = status;
        }
    }
}
