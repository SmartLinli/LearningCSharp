using System;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im18 = new Class(infomationManagement, 2018);
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
            im18.Students = students;

            StudentUi.Display
                ("查找年龄最大的学生"
                , im18.Students.Max
                    ((s, s2) => s.BirthDate <= s2.BirthDate));
            StudentUi.Display
                ("查找姓李的学生"
                , im18.Students.Find
                    (s => s.Name.Substring(0, 1) == "李"));
            Console.WriteLine
                ("\n查找姓李的学生人数：{0}人"
                , im18.Students.Count
                    (s => s.Name.Substring(0, 1) == "李"));
            StudentUi.Display
                ("将所有学生性别改为女性"
                , im18.Students.Modify
                    (s => s.Gender = Gender.FEMALE));
            StudentUi.Display
                ("对所有学生按照年龄由大到小排序"
                , im18.Students.Sort
                    ((s, s2) => s.BirthDate.CompareTo(s2.BirthDate)));
            Console.Read();
        }
    }
}
