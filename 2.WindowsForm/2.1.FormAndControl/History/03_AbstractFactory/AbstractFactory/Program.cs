using System;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    class Program
    {
        static void Main()
        {
            //ComputerExaminationAbstractFactory oopExamFactory = new ComputerExaminationAbstractFactory();
            //IExaminationRoom oopExamRoom = oopExamFactory.CreateExaminationRoom();
            //IInvigilator oopInvigilator = oopExamFactory.CreateInvigilator();
            //oopExamRoom.ShowResult();
            //oopInvigilator.ShowResult();
            //IExamination oopExam = oopExamFactory.CreateExamination("面向对象程序设计期末考");
            //oopExam.ShowResult();

            WrittenExaminationAbstractFactory englishExamFactory = new WrittenExaminationAbstractFactory();
            IExaminationRoom englishExamRoom = englishExamFactory.CreateExaminationRoom();
            IInvigilator englishInvigilator = englishExamFactory.CreateInvigilator();
            englishExamRoom.ShowResult();
            englishInvigilator.ShowResult();
            //IExamination englishExam = englishExamFactory.CreateExamination("大学英语2期末考");
            //englishExam.ShowResult();
            Console.ReadLine();
        }
    }
}
