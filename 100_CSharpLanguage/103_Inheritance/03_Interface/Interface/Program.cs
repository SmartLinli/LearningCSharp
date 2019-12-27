using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            /*定义教师、督导、本科生、研究生；*/
            Faculty mrLin = new Faculty("2004034", "林立", Gender.MALE);
            Faculty msYang = new Faculty("2002010", "杨雪梅", Gender.FEMALE);
            IDeepEvaluate mrHuang = new Inspector("2011044", "黄至辉", Gender.MALE);				//通过接口声明对象类型；
            Postgraduate girl = new Postgraduate("2190757001", "李四", Gender.FEMALE);
            /*定义观摩课；*/
            OpenLesson oop = new OpenLesson()
            {
                Lecturer = mrLin,
                Audiences = new IEvaluate[] { msYang, girl, mrHuang }                           //通过接口声明对象类型；
            };
            /*评教；*/
            oop.Evaluate();
            mrHuang.Analyse(mrLin);																//只能调用该接口内的方法；
            mrHuang.Propose(mrLin);
            /*申报课题*/
            msYang.SubjectTitle = "基于词向量计算的中医症状术语相似度研究";                       
            girl.SubjectTitle = "中医电子病历系统设计";
            msYang.SubmitSubject();
            girl.SubmitSubject();
            Read();
        }
    }
}