using System;
using static System.Console;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    class Program
    {
        static void Main()
        {
            WriteLine("《面向对象程序设计》上机考试安排：");
            ComputerExaminationAbstractFactory oopExamFactory = new ComputerExaminationAbstractFactory();       //根据需要定义抽象工厂；
            IExaminationRoom oopExamRoom = oopExamFactory.CreateExaminationRoom();                              //抽象工厂创建产品族中的某产品；
            IInvigilator oopInvigilator = oopExamFactory.CreateInvigilator();                                   //抽象工厂创建产品族中的某产品；
            oopExamRoom.ShowResult();
            oopInvigilator.ShowResult();

            WriteLine("《英语》笔试安排：");
            WrittenExaminationAbstractFactory englishExamFactory = new WrittenExaminationAbstractFactory();
            IExaminationRoom englishExamRoom = englishExamFactory.CreateExaminationRoom();
            IInvigilator englishInvigilator = englishExamFactory.CreateInvigilator();
            englishExamRoom.ShowResult();
            englishInvigilator.ShowResult();
            Console.ReadLine();
        }
    }
}
