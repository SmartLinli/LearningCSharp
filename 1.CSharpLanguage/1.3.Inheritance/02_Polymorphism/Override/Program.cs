using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            /*定义教师、本科生、研究生、交换生；*/
            Faculty msYang = new Faculty("2002010", "杨雪梅", Gender.FEMALE, "人文与管理学院")
            {
                Speciality = "数据仓库与数据挖掘、医学统计"
            };
            Faculty mrLin = new Faculty("2004034", "林立", Gender.MALE, "人文与管理学院")
            {
                Speciality = "面向对象程序设计、数据库"
            };
            Undergraduate boy = new Undergraduate("3190707000", "张三", Gender.MALE, "19信管");
            Postgraduate girl = new Postgraduate("2190757001", "李四", Gender.FEMALE, msYang);
            girl.AssignDirection("数据可视化");
            ExchangeStudent newGuy = new ExchangeStudent("20190531001", "王五", Gender.MALE, "19信管", "江西中医药大学");
            newGuy.Instructor = msYang;
            /*介绍；注册；转专业；*/
            mrLin.Intro();                                                                          //调用派生类重写的方法；
            WriteLine();
            boy.Intro();
            WriteLine();
            girl.Intro(); 
            WriteLine();
            newGuy.Intro();
            WriteLine();
            boy.Register();
            girl.Register();
            newGuy.Register();
            newGuy.TransferToMajor("18健管");														//调用派生类的新方法；
            Read();
        }
    }
}