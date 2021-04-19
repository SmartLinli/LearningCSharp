using System;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    class Program
    {
        static void Main()
        {
            ComputerExaminationAbstractFactory oopExamFactory = new ComputerExaminationAbstractFactory();       //根据需要定义抽象工厂；
            IExaminationRoom oopExamRoom = oopExamFactory.CreateExaminationRoom();                              //抽象工厂创建产品族中的某产品；
            IInvigilator oopInvigilator = oopExamFactory.CreateInvigilator();                                   //抽象工厂创建产品族中的某产品；
            oopExamRoom.ShowResult();
            oopInvigilator.ShowResult();

            WrittenExaminationAbstractFactory englishExamFactory = new WrittenExaminationAbstractFactory();
            IExaminationRoom englishExamRoom = englishExamFactory.CreateExaminationRoom();
            IInvigilator englishInvigilator = englishExamFactory.CreateInvigilator();
            englishExamRoom.ShowResult();
            englishInvigilator.ShowResult();
            Console.ReadLine();
        }
    }
}
