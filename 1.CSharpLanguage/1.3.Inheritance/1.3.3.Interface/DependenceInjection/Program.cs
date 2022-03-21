using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            Undergraduate 
                boy = new Undergraduate("3220707001", "张三")
                , girl = new Undergraduate("3220707002", "李四");
            boy.InstructorService = new AssignInstructorByRandom();               //将实现了指定接口的不同对象赋予（注入）该属性，从而实现不同的行为；
            girl.InstructorService = new AssignInstructorBySelection();

			boy.AssignInstructor();
            girl.AssignInstructor();
            Read();
        }
    }
}