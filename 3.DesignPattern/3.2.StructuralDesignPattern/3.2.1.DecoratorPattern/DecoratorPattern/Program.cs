using static System.Console;

namespace SmartLin.LearningCSharp.DecoratorPattern
{
    class Program
    {
        static void Main()
        {
            Student student = new Student("3180707001", "周林好");                          //定义被装饰者（亦即装饰者的基类）；
            student = new StudentCadre(student)                                             //定义装饰者；装饰者（间接）派生于被装饰者，故可直接向后者赋值；
            {
                Duty = "班级团支书"                                                          //被装饰者作为基类，无法访问装饰者的成员，只能通过装饰者的初始化器来向后者的成员赋值；
            };
            student = new ExchangedStudent(student)                                         //定义更多装饰者，并引用先前装饰者；
            {
                DestinationSchool = "江西中医药大学",
                DestinationMajor = "医学信息工程"
            };
            student.Intro();                                                                //调用方法；该方法已经过各装饰者（亦即派生类）的重写；
            WriteLine();

            Student student2 = new Student("3180707002", "林钦妹");
            StudentCadre studentCadre = new StudentCadre(student2)
            {
                Duty = "组织委员"
            };
            ExchangedStudent exchangedStudent = new ExchangedStudent(studentCadre)
            {
                DestinationSchool = "云南中医药大学",
                DestinationMajor = "中医药信息学"
            };
            exchangedStudent.Intro();
            Read();
        }
    }
}
