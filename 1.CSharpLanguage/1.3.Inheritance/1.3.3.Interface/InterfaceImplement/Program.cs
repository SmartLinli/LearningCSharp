using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            Faculty mrLin = new Faculty("2004034", "林立");
            Faculty msYang = new Faculty("2002010", "杨雪梅");
			Student boy = new Student("3210707001", "张三");

			msYang.Evaluate(mrLin);                                                                //调用接口约定的方法；
			boy.Evaluate(mrLin);
            Read();
        }
    }
}