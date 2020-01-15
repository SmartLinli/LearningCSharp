using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
			Faculty msYang = new Faculty("2002010", "杨雪梅", Gender.FEMALE, "人文与管理学院")
			{
				Speciality = "数据仓库与数据挖掘、医学统计"
			};
			Student boy = new Student("3190707000", "张三", Gender.MALE);

			msYang.Intro();                                                                         //调用派生类重写的方法；
            boy.Intro();
            Read();
        }
    }
}