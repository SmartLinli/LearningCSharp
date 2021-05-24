using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class ValidationItemBeforeInputRate
    {
        public LearningStatus LearningStatus
        {
            get;
            set;
        }
        public DateTime OpeningDate
        {
            get;
            set;
        }
        public DateTime ClosingDate
        {
            get;
            set;
        }
        public ValidationItemBeforeInputRate(LearningStatus learningStatus, DateTime openingDate, DateTime closingDate)
        {
            this.LearningStatus = learningStatus;
            this.OpeningDate = openingDate;
            this.ClosingDate = closingDate;
        }
    }
}
