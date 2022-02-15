using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	class Program
    {
        static void Main()
        {
			Undergraduate boy = new Undergraduate("3220707001", "张三", Gender.MALE)
			{
				Class = "22信管",
				Instructor = "林立"                                                                     //派生类访问自身的属性；
			};
			Postgraduate girl = new Postgraduate("2190757002", "李四", Gender.FEMALE);
			boy.Intro();																				//派生类调用顶层基类的方法；
			girl.Intro();
			boy.Register();                                                                             //派生类调用基类的方法；
            girl.Register();
            girl.AssignDirection("数据可视化");                                                          //派生类调用自身的方法；
			Read();
        }
    }
}