using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class StudentRateFactory : IRateFactory<LearningTask>
    {
        public StudentRate Create(LearningTask learningTask, DateTime closingDate)
        {
            StudentRate studentRate = new StudentRate();
            studentRate.Target = learningTask;
            studentRate.ClosingDate = closingDate;
            return studentRate;
        }
        public StudentRate Create(LearningTask learningTask, DateTime openingDate, DateTime closingDate)
        {
            StudentRate studentRate = this.Create(learningTask, closingDate);
            studentRate.OpeningDate = openingDate;
            return studentRate;
        }
    }

}
