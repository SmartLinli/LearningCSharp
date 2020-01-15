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

			msYang.Evaluate(mrLin);
			mrHuang.Evaluate(mrLin);

			msYang.SubjectTitle = "基于词向量计算的中医症状术语相似度研究";
			mrHuang.SubjectTitle = "基于差分隐私的医疗大数据隐私保护模型应用研究";
            msYang.SubmitSubject();
			mrHuang.SubmitSubject();
            Read();
        }
    }
}