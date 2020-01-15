using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            Faculty mrLin = new Faculty("2004034", "林立");
            Faculty msYang = new Faculty("2002010", "杨雪梅");
			Faculty mrHuang = new Faculty("2011044", "黄至辉");									
            Student girl = new Student("2190757001", "李四");
            OpenLesson oop = new OpenLesson()
            {
                Lecturer = mrLin,
                Audiences = new IEvaluate[] { msYang, mrHuang, girl }                           //通过接口声明对象类型；
            };

            oop.Evaluate();
            Read();
        }
    }
}