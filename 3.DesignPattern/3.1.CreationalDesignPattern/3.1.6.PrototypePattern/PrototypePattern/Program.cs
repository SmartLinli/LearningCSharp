using static System.Console;

namespace SmartLin.LearningCSharp.PrototypePattern
{
    class Program
    {
        static void Main()
        {

            CoursePrototypeManager courseManager = new CoursePrototypeManager();
            Course oop = new Course("2060316", "面向对象程序设计", 4.5f);
            oop.Display();

            WriteLine("开始备份：");
            oop = courseManager.Backup(oop);                                                    //通过原型管理器，保存对象的复制品；
            oop.Number += "_2";
            oop.Display();

            oop = courseManager.Backup(oop);
            oop.Name += "与C#";
            oop.Display();

            oop = courseManager.Backup(oop);
            oop.Credit += 0.5f;
            oop.Display();

            WriteLine("开始还原：");
            while (courseManager.HasBackup)
            {
                oop = courseManager.Restore();                                                  //从原型管理器获取对象的复制品；
                oop.Display();
            }         

            Read();
        }
    }
}
