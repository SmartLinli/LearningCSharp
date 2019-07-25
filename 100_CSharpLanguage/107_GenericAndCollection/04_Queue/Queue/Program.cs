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
                new Student("3180707001", "周林好")
                , new Student("3180707002", "林钦妹")
                , new Student("3180707003", "胡方珍")
                , new Student("3180707004", "谢永成")
            };
            studentAuditManager.EnterStudents(students);
            studentAuditManager.AuditStudents();
            students = new List<Student>()                                                
            {                                                                      
                new Student("3180707005", "龙禹吉")
                , new Student("3180707006", "陈雯婷")
                , new Student("3180707007", "李乐健")
            };
            studentAuditManager.EnterStudents(students);
            studentAuditManager.AuditStudents();
            studentAuditManager.ShowStudentsPassed();
            Read();
        }
    }
}
