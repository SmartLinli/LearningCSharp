using System;
using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
    {
        static void Main()
        {
            Student[] students =                                                    
            {
                new Student("3220707001", "曾羽", Gender.MALE, new DateTime(2004, 10, 10)),
                new Student("3220707002", "纪凝", Gender.MALE, new DateTime(2003, 11, 11)),
                new Student("3220707003", "宋明杰", Gender.MALE, new DateTime(2004, 8, 28)),
                new Student("3220707004", "温歆滢", Gender.FEMALE, new DateTime(2004, 6, 14)),
                new Student("3220707005", "连云飞", Gender.MALE, new DateTime(2004, 5, 7)),
                new Student("3220707006", "张吉恒煊", Gender.MALE, new DateTime(2003, 12, 22)),
                new Student("3220707007", "徐思亮", Gender.MALE, new DateTime(2004, 1, 29)),
                new Student("3220707008", "林艺玲", Gender.FEMALE, new DateTime(2003, 10, 25)),
                new Student("3220707009", "张君英", Gender.FEMALE, new DateTime(2003, 5, 5)),
                new Student("3220707010", "张昕楠", Gender.FEMALE, new DateTime(2004, 9, 8))
            };
            GenericContainer<Student> im22Students = new GenericContainer<Student>();
            im22Students.Add(students);
            im22Students.ForEach(s => s.Register());
            foreach (Student student in im22Students)
            {
                SmsManager.Inform(student, "请做好开学准备");
            }
            StudentUi.Display
                ("查找学号为3220707001的学生",
                 im22Students["3220707001"]);
            StudentUi.Display
                ("查找姓张的学生",
                 im22Students.Find(s => s.Name.Substring(0, 1) == "张"));
            StudentUi.Display
                ("将所有男生改为女性",
                 im22Students
                    .Find(s => s.Gender == Gender.MALE)
                    .ForEach(s => s.Gender = Gender.FEMALE));
            Read();
        }
    }
}
