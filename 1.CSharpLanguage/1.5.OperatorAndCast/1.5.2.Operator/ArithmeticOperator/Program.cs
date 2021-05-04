using static System.Console;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
    class Program
    {
        static void Main()
        {
            Student newStudent = new Student("3200707001", "闭敏媛");
            Student[] newStudents =                                                    
            {
                new Student("3200707002", "储艺"),
                new Student("3200707003", "胡江彬"),
                new Student("3200707004", "林金川"),
                new Student("3200707005", "王泉井")
            };
            Class im20 = new Class("20信管");
            im20 += newStudent;
            im20 += newStudents;
            foreach (Student student in im20)
            {
                WriteLine($"{student.Number,-12}{student.Name}");
            }
            Read();
        }
    }
}
