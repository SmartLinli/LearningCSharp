using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            /*定义本科生；*/
            Undergraduate 
                boy = new Undergraduate("3180707001", "张三", Gender.MALE)
                , girl = new Undergraduate("3180707002", "李四", Gender.FEMALE);
            boy.InstructorAssignService = new InstructorAssignByRandom();               //将派生于指定接口的不同对象赋予（注入）该属性，从而实现不同的行为；
            girl.InstructorAssignService = new InstructorAssignBySelection();
            /*分配导师；*/
            boy.InstructorAssignService.Assign();
            girl.InstructorAssignService.Assign();
            Console.Read();
        }
    }
}