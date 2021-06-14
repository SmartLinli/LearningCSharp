using static System.Console;

namespace SmartLin.LearningCSharp.FacadePattern
{
    class Program
    {
        static void Main()
        {
            Student newStudent = new Student("3210707001", "张三", Gender.MALE);
            StudentAffairOffice.WelCome(newStudent);
            ReadLine();
        }
    }
}
