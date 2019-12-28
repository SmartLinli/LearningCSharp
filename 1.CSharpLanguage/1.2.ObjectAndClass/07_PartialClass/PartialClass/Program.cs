using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Student girl = new Student("3190707000", "李四", Gender.FEMALE);                
            girl.Email = "3190707000@fjtcm.edu.cn";                                     //访问部分类的成员；
            girl.SendEmail("期末成绩已开放查询。");
            Read();
        }
    }
}
