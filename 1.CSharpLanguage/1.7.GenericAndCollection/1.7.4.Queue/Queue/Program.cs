using static System.Console;
using System.Collections.Generic;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
    {
        static void Main()
        {
            StudentAuditManager studentAuditManager = new StudentAuditManager();
            List<Student> students = new List<Student>()
            {
                new Student("3200707001", "闭敏媛"),
                new Student("3200707002", "储艺"),
                new Student("3200707003", "胡江彬"),
                new Student("3200707004", "林金川")
            };
            studentAuditManager.EnterStudents(students);
            studentAuditManager.AuditStudents();
            students = new List<Student>()
            {
                new Student("3200707005", "王泉井"),
                new Student("3200707006", "刘伯铭"),
                new Student("3200707007", "王子驭")
            };
            studentAuditManager.EnterStudents(students);
            studentAuditManager.AuditStudents();
            studentAuditManager.ShowStudentsPassed();
            Read();
        }
    }
}
