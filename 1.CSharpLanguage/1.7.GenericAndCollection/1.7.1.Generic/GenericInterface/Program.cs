using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
	class Program
    {
        static void Main()
        {
            Course oop = new Course("2060238", "面向对象程序设计",4.5);
            Student boy = new Student("3220707001", "张三", Gender.MALE);
            CourseUi courseUi = new CourseUi();
            StudentUi studentUi = new StudentUi();
            courseUi.Display(oop);
            studentUi.Display(boy);
            Read();
        }
    }
}
