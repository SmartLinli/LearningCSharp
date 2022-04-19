using System;
using static System.Console;

namespace SmartLin.LearningCSharp.DelegateAndEvent
{
	class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im21 = new Class(infomationManagement, 2021);
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
            im21.Students = students;
            WriteLine("\n----------通过不同方法，实现不同查询----------\n");
            StudentUi.Display
                ("查找学号为3210707001的学生"
                , im21.Students.FindByNumber("3210707001"));
            StudentUi.Display
                ("查找名为田杰红的学生"
                , im21.Students.FindByName("田杰红"));
            StudentUi.Display
                ("查找男生"
                , im21.Students.FindByGender(Gender.MALE));
            StudentUi.Display
                ("查找生日早于2003年的学生"
                , im21.Students.FindByBirthDateEarlierThan(new DateTime(2003, 1, 1)));
            WriteLine("\n----------通过不同委托，实现不同查询----------\n");
            StudentUi.Display
                ("查找名为田杰红的学生"
                , im21.Students.FindBy
                    (StudentService.FindByName, "田杰红"));															//通过方法名直接创建委托实例；
            StudentUi.Display
                ("查找男生"
                , im21.Students.FindBy
                    (StudentService.FindByGender, Gender.MALE));
            StudentUi.Display
                ("查找生日早于2003年的学生"
                , im21.Students.FindBy
                    (StudentService.FindByBirthDateEarlierThan, new DateTime(2003, 1, 1)));
            WriteLine("\n----------通过λ表达式，实现不同查询或操作----------\n");
            StudentUi.Display
                ("查找姓刘的学生"
                , im21.Students.Find
                    ((s) => { return s.Name.Substring(0, 1) == "刘"; }));                                           //通过Lambda表达式实现匿名方法，进而创建委托实例；编译器将从委托中的方法签名获取返回类型、参数类型；
            StudentUi.Display
                ("查找男生"
                , im21.Students.Find
                    (s => { return s.Gender == Gender.MALE; }));                                                    //若只有1个参数，可省略括号；
            StudentUi.Display
                ("查找生于2003年上半年的学生"
                , im21.Students.Find
                    (s => s.BirthDate.Year == 2003 && s.BirthDate.Month <= 6));                                     //单语句可省略{ return ; }；
            StudentUi.Display
                ("将所有男生改为女性"
                , im21.Students
                    .Find(s => s.Gender == Gender.MALE)
                    .Modify(s => s.Gender = Gender.FEMALE));
            Read();
        }
    }
}
