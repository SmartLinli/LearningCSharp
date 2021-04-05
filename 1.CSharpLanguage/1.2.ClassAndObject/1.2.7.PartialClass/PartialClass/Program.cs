using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Student girl = new Student("3210707002", "李四", Gender.FEMALE);                
            girl.EmailAddress = "3210707002@fjtcm.edu.cn";                                     //访问部分类的成员；
            girl.SendEmail("新生须知");
            Read();
        }
    }
}
