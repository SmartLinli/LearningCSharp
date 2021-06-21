using static System.Console;

namespace SmartLin.LearningCSharp.StatePattern
{
    class Program
    {
        static void Main()
        {
            Examinee student = new Examinee("3180707001", "周林好");
            student.Grading(55m);
            student.Grading(58m);
            student.Grading(59m);
            student.Grading(60m);
            ReadLine();
        }
    }
}
