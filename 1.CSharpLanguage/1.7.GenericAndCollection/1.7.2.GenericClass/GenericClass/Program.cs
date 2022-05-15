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
                new Student("3210707001", "田杰红", Gender.FEMALE, new DateTime(2001, 9, 10)),
                new Student("3210707002", "刘兰", Gender.FEMALE, new DateTime(2003, 2, 9)),
                new Student("3210707003", "吴争宇", Gender.MALE, new DateTime(2004, 1, 5)),
                new Student("3210707004", "廖丽珍", Gender.FEMALE, new DateTime(2002, 11, 12)),
                new Student("3210707005", "王诗琴", Gender.FEMALE, new DateTime(2003, 10, 28)),
                new Student("3210707006", "罗清香", Gender.FEMALE, new DateTime(2003, 2, 24)),
                new Student("3210707007", "谢晓丹", Gender.FEMALE, new DateTime(2002, 10, 19)),
                new Student("3210707008", "刘浩雄", Gender.MALE, new DateTime(2002, 9, 25)),
                new Student("3210707009", "程琨耀", Gender.MALE, new DateTime(2002, 11, 29)),
                new Student("3210707010", "李健铭", Gender.MALE, new DateTime(2002, 3, 25))
            };
            GenericContainer<Student> im21Students = new GenericContainer<Student>();
            im21Students.Add(students);
            im21Students.ForEach(s => s.Register());
            foreach (Student student in im21Students)
            {
                SmsManager.Inform(student, "请做好开学准备");
            }
            StudentUi.Display
                ("查找学号为3210707001的学生",
                 im21Students["3210707001"]);
            StudentUi.Display
                ("查找姓李的学生",
                 im21Students.Find(s => s.Name.Substring(0, 1) == "李"));
            StudentUi.Display
                ("将所有男生改为女性",
                 im21Students
                    .Find(s => s.Gender == Gender.MALE)
                    .ForEach(s => s.Gender = Gender.FEMALE));
            Read();
        }
    }
}
