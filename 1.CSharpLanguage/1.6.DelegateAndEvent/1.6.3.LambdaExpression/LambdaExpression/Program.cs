using System;
using static System.Console;

namespace SmartLin.LearningCSharp.DelegateAndEvent
{
	class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im22 = new Class(infomationManagement, 2022);
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
            im22.Students = students;
            WriteLine("\n----------通过不同方法，实现不同查询----------\n");
            StudentUi.Display
                ("查找学号为3220707001的学生",
                 im22.Students.FindByNumber("3220707001"));
            StudentUi.Display
                ("查找名为曾羽的学生",
                 im22.Students.FindByName("曾羽"));
            StudentUi.Display
                ("查找男生",
                 im22.Students.FindByGender(Gender.MALE));
            StudentUi.Display
                ("查找生日早于2004年的学生",
                 im22.Students.FindByBirthDateEarlierThan(new DateTime(2004, 1, 1)));
            WriteLine("\n----------通过不同委托，实现不同查询----------\n");
            StudentUi.Display
                ("查找名为田杰红的学生",
                 im22.Students.FindBy
                    (StudentService.FindByName, "曾羽"));															//通过方法名直接创建委托实例；
            StudentUi.Display
                ("查找男生",
                 im22.Students.FindBy
                    (StudentService.FindByGender, Gender.MALE));
            StudentUi.Display
                ("查找生日早于2004年的学生",
                 im22.Students.FindBy
                    (StudentService.FindByBirthDateEarlierThan, new DateTime(2004, 1, 1)));
            WriteLine("\n----------通过λ表达式，实现不同查询或操作----------\n");
            StudentUi.Display
                ("查找姓刘的学生",
                 im22.Students.Find
                    ((s) => { return s.Name.Substring(0, 1) == "张"; }));                                           //通过Lambda表达式实现匿名方法，进而创建委托实例；编译器将从委托中的方法签名获取返回类型、参数类型；
            StudentUi.Display
                ("查找男生",
                 im22.Students.Find
                    (s => { return s.Gender == Gender.MALE; }));                                                    //若只有1个参数，可省略括号；
            StudentUi.Display
                ("查找生于2004年上半年的学生",
                 im22.Students.Find
                    (s => s.BirthDate.Year == 2004 && s.BirthDate.Month <= 6));                                     //单语句可省略{ return ; }；
            StudentUi.Display
                ("将所有男生改为女性",
                 im22.Students
                    .Find(s => s.Gender == Gender.MALE)
                    .Modify(s => s.Gender = Gender.FEMALE));
            Read();
        }
    }
}
