using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            int i;
            //WriteLine($"{i}");                        //代码编辑器将提示错误：使用了未赋值的局部变量；
            Student boy;
            //WriteLine($"{boy.Name}");                 //代码编辑器将提示错误：使用了未赋值的局部变量；
            boy = StudentRepository.GetStudent("3210707002");
            //WriteLine(boy.Name);                      //运行时将提示错误：未将对象引用设置到对象的实例；
            if (boy != null)
            {
                WriteLine(boy.Name);
            }
            else
            {
                WriteLine("查无此人！");
            }
            Read();
        }
    }
}
