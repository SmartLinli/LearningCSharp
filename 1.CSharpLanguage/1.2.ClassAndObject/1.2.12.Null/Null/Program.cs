using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            int i;                                      //代码编辑器将提示警告，表示该局部变量未赋值；
            //WriteLine($"{i}");                        //代码编辑器将提示错误：使用了未赋值的局部变量；
            Student boy;                                //代码编辑器不做任何提示；
            //WriteLine($"{boy.Name}");                 //代码编辑器将提示错误：使用了未赋值的局部变量；
            boy = StudentRepository.GetStudent("3230707002");
            //WriteLine(boy.Name);                      //运行时将提示错误：未将对象引用设置到对象的实例；
            if (boy == null)
            {
                WriteLine("查无此人！");
                return;
            }
            WriteLine(boy.Name);
            Read();
        }
    }
}
