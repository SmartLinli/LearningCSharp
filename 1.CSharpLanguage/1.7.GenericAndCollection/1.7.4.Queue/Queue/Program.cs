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
                new Student("3220707001", "曾羽"),
                new Student("3220707002", "纪凝"),
                new Student("3220707003", "宋明杰"),
                new Student("3220707004", "温歆滢")
            };
            studentAuditManager.EnterStudents(students);
            studentAuditManager.AuditStudents();
            
            students = new List<Student>()
            {
                new Student("3220707005", "连云飞"),
                new Student("3210707006", "张吉恒煊"),
                new Student("3210707007", "徐思亮")
            };
            studentAuditManager.EnterStudents(students);
            studentAuditManager.AuditStudents();
            studentAuditManager.ShowStudentsPassed();
            Read();
        }
    }
}
