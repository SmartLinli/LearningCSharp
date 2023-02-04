using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Student boy = Student.Create("323070700", "张三", Gender.MALE);          //无需实例化非静态类，即可调用其静态方法，从而实现创造行为类设计模式；
			if (boy == null)
            {
                return;
            }
			boy.ShowInfo();
			Read();
        }
    }
}
