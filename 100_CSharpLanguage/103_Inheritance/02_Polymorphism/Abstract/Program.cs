using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            /*定义教师、本科生、研究生、交换生；*/

            Undergraduate boy = new Undergraduate("3190707000", "张三", Gender.MALE, "19信管");
            Postgraduate girl = new Postgraduate("2190757001", "李四", Gender.FEMALE, "杨雪梅");
            girl.AssignDirection("数据可视化");
            /*介绍；注册；转专业；*/
            boy.Intro();
            WriteLine();
            girl.Intro();
            WriteLine();
            boy.Register();
            girl.Register();
            Read();
        }
    }
}