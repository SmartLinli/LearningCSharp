using System;

namespace SmartLin.LearningCSharp.BuilderPattern
{
    class Program
    {
        static void Main()
        {
            WrittenExaminationBuilder englishExamBuilder = new WrittenExaminationBuilder();             //定义建造者；
            IExamination englishExam = englishExamBuilder.Build();                                      //建造产品；
            englishExam.ShowResult();

            HonestyExaminationDirector militaryExamDirector = new HonestyExaminationDirector();         //定义指挥者；
            IExamination militaryExam = militaryExamDirector.Construct();                               //构建产品；
            militaryExam.ShowResult();

            Console.ReadLine();
        }
    }
}
