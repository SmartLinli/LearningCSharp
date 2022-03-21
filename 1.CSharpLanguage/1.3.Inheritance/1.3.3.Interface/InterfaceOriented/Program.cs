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
            IEvaluate[] audiences = { msYang, mrHuang, girl };          //对象的类型为接口（数组）；
            OpenLesson oop = new OpenLesson()
            {
                Lecturer = mrLin,
                Audiences = audiences
            };
            oop.Evaluate();
            Read();
        }
    }
}