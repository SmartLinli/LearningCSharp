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
                new Student("3200707001", "闭敏媛", Gender.FEMALE, new DateTime(2001, 7, 21))
                , new Student("3200707002", "储艺", Gender.FEMALE, new DateTime(2001, 7, 12))
                , new Student("3200707003", "胡江彬", Gender.FEMALE, new DateTime(2000, 9, 6))
                , new Student("3200707004", "林金川", Gender.MALE, new DateTime(2001, 7, 18))
                , new Student("3200707005", "王泉井", Gender.FEMALE, new DateTime(2000, 10, 12))
                , new Student("3200707006", "刘伯铭", Gender.FEMALE, new DateTime(2002, 2, 17))
                , new Student("3200707007", "王子驭", Gender.MALE, new DateTime(2002, 7, 29))
                , new Student("3200707009", "郑喻文", Gender.MALE, new DateTime(2002, 5, 11))
                , new Student("3200707010", "朱素清", Gender.FEMALE, new DateTime(2002, 5, 17))
                , new Student("3200707011", "何延斌", Gender.FEMALE, new DateTime(2002, 12, 17))
            };
            GenericContainer<Student> im20Students = new GenericContainer<Student>();
            im20Students.Add(students);
            im20Students.ForEach(StudentService.Register);
            foreach (Student student in im20Students)
            {
                SmsManager.Inform(student, "请做好开学准备");
            }
            StudentUi.Display
                ("查找学号为3200707001的学生"
                , im20Students["查找学号为3200707001的学生"]);
            StudentUi.Display
                ("查找姓李的学生"
                , im20Students.Find(s => s.Name.Substring(0, 1) == "李"));
            StudentUi.Display
                ("将所有男生改为女性"
                , im20Students
                    .Find(s => s.Gender == Gender.MALE)
                    .ForEach(s => s.Gender = Gender.FEMALE));
            Read();
        }
    }
}
