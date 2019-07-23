using System;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
    {
        static void Main()
        {
            Student[] students =                                                    
            {                                                                      
                new Student("3180707001", "周林好", Gender.FEMALE, new DateTime(2000, 4, 17))
                , new Student("3180707002", "林钦妹", Gender.FEMALE, new DateTime(1999, 10, 18))
                , new Student("3180707003", "胡方珍", Gender.FEMALE, new DateTime(2000, 1, 22))
                , new Student("3180707004", "谢永成", Gender.MALE, new DateTime(2000, 3, 2))
                , new Student("3180707005", "龙禹吉", Gender.FEMALE, new DateTime(1999, 8, 10))
                , new Student("3180707006", "陈雯婷", Gender.FEMALE, new DateTime(2000, 8, 24))
                , new Student("3180707007", "李乐健", Gender.MALE, new DateTime(2000, 7, 10))
                , new Student("3180707008", "李志杰", Gender.MALE, new DateTime(2001, 1, 14))
                , new Student("3180707009", "刘燕婷", Gender.FEMALE, new DateTime(2000, 9, 28))
                , new Student("3180707010", "梁婷", Gender.FEMALE, new DateTime(1999, 6, 12))
            };
            GenericContainer<Student> im18Students = new GenericContainer<Student>();
            im18Students.Add(students);
            im18Students.ForEach(StudentService.Register);
            foreach (Student student in im18Students)
            {
                SmsManager.Inform(student, "请做好开学准备");
            }
            StudentUi.Display
                ("查找学号为3180707001的学生"
                , im18Students["3180707001"]);
            StudentUi.Display
                ("查找姓李的学生"
                , im18Students.Find(s => s.Name.Substring(0, 1) == "李"));
            StudentUi.Display
                ("将所有男生改为女性"
                , im18Students
                    .Find(s => s.Gender == Gender.MALE)
                    .ForEach(s => s.Gender = Gender.FEMALE));
            Console.Read();
        }
    }
}
