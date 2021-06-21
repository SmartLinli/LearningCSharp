using static System.Console;

namespace SmartLin.LearningCSharp.TemplateMethod
{
    class Program
    {
        static void Main()
        {
            ExaminationArrangementTemplate oopExam = new ComputerExaminationArrangement();      //定义具体模板；
            oopExam.DeclareExamination();                                                       //调用（继承自抽象模板的）模板方法；
            ReadLine();
        }
    }
}
