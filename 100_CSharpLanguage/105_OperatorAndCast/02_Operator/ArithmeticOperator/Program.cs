using static System.Console;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
    class Program
    {
        static void Main()
        {
            Student newStudent = new Student("3180707001", "周林好");
            Student[] newStudents =                                                    
            {                                                                      
                new Student("3180707002", "林钦妹")
                ,new Student("3180707003", "胡方珍")
                ,new Student("3180707004", "谢永成")
                ,new Student("3180707005", "龙禹吉")
            };
            Class im18 = new Class("18信管");
            im18 += newStudent;
            im18 += newStudents;
            foreach (Student student in im18)
            {
                WriteLine("{0,-12}{1}", student.Number, student.Name);
            }
            Read();
        }
    }
}
