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
                new Student("3210707001", "田杰红"),
                new Student("3210707002", "刘兰"),
                new Student("3210707003", "吴争宇"),
                new Student("3210707004", "廖丽珍")
            };
            studentAuditManager.EnterStudents(students);
            studentAuditManager.AuditStudents();
            
            students = new List<Student>()
            {
                new Student("3210707005", "王诗琴"),
                new Student("3210707006", "罗清香"),
                new Student("3210707007", "谢晓丹")
            };
            studentAuditManager.EnterStudents(students);
            studentAuditManager.AuditStudents();
            studentAuditManager.ShowStudentsPassed();
            Read();
        }
    }
}
