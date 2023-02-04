using static System.Console;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
    class Program
    {
        static void Main()
        {
            Student newStudent = new Student("3220707001", "曾羽");
            Student[] newStudents =                                                    
            {
                new Student("3220707002", "纪凝"),
                new Student("3220707003", "宋明杰"),
                new Student("3220707004", "温歆滢"),
                new Student("3220707005", "连云飞")
            };
            Class im22 = new Class("22信管");
            im22 += newStudent;
            im22 += newStudents;
            foreach (Student student in im22)
            {
                WriteLine($"{student.Number,-12}{student.Name}");
            }
            Read();
        }
    }
}
