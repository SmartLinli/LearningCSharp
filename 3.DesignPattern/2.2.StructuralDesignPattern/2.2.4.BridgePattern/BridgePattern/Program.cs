using System;

namespace SmartLin.LearningCSharp.BridgePattern
{
    class Program
    {
        static void Main()
        {
            ICourseOperation
                 written = new CourseOperationWritten()
               , paperless = new CourseOperationPaperless();                        //定义各类实现者；
            AbstractCourse[] courses =                                              //定义各类修正抽象角色；
            {
                new ClassroomCourse("2120014","中国近现代史纲要",written)           //注入各类实现者；
                    { Lecturer="林海" },
                new ClassroomCourse("2060316","面向对象程序设计",paperless)
                    { Lecturer="林立" },
                new OnlineCourse("2060267","医学信息学",written)
                    { Source="超星学习通" },
                new OnlineCourse("2060310","动态网站建设",paperless)
                    { Source="网易公开课" }
            };
            foreach (var course in courses)
            {
                course.Exercise();
                course.Examine();
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
