using static System.Console;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
    class Program
    {
        static void Main()
        {
            Student newStudent = new Student("3210707001", "田杰红");
            Student[] newStudents =                                                    
            {
                new Student("3210707002", "刘兰"),
                new Student("3210707003", "吴争宇"),
                new Student("3210707004", "廖丽珍"),
                new Student("3210707005", "王诗琴")
            };
            Class im21 = new Class("21信管");
            im21 += newStudent;
            im21 += newStudents;
            foreach (Student student in im21)
            {
                WriteLine($"{student.Number,-12}{student.Name}");
            }
            Read();
        }
    }
}
