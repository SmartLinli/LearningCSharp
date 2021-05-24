using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class StudentRateRepository:IRepository<StudentRate,string>
    {
        public StudentRate[] FindAll(string studentNo)
        {
            Faculty
                mrLin = new Faculty("2004034", "立立")
                , mrChen = new Faculty("2009012", "陈林")
                , msZhang = new Faculty("2001056", "张");
            Course
                oop = new Course("2060238", "面向对象程序设计")
                , network = new Course("2060241", "计算机网络")
                , cProgramming = new Course("2060238", "C语言程序设计");
            LearningTask
                oopLearningTask = new LearningTask("18-19-2_238", mrLin, oop, LearningStatus.Normal)
                , networkLearningTask = new LearningTask("18-19-2_241", mrChen, network, LearningStatus.Normal)
                , cProgrammingLearningTask = new LearningTask("18-19-2_238_b", msZhang, cProgramming, LearningStatus.Retaking);
            DateTime rateOpeningDate = new DateTime(2019, 6, 10);
            DateTime rateClosingDate = new DateTime(2019, 6, 20);
            StudentRate oopRate=new StudentRate(
            boy.LearningTasks = new LearningTask[] { oopLearningTask, networkLearningTask, cProgrammingLearningTask };
            boy.LearningTasks[0].FinalScore = 78M;
            boy.LearningTasks[1].FinalScore = 82.5M;
            boy.LearningTasks[2].FinalScore = 62M;

            StudentRate[] studentRates = new StudentRate[]
                {new StudentRate(),new StudentRate()};

            return studentRates;
        }
        public  void Save(StudentRate studentRate)
        {
            ;
        }
    }
}
