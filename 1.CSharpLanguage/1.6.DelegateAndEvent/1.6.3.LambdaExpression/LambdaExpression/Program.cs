using System;
using static System.Console;

namespace SmartLin.LearningCSharp.DelegateAndEvent
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
            /*通过不同方法，实现不同查询；
            StudentUi.Display
                ("查找学号为3180707001的学生"
                , im18.Students.FindByNumber("3180707001"));
            StudentUi.Display
                ("查找名为梁婷的学生"
                , im18.Students.FindByName("梁婷"));
            StudentUi.Display
                ("查找男生"
                , im18.Students.FindByGender(Gender.MALE));
            StudentUi.Display
                ("查找生日早于2000年的学生"
                , im18.Students.FindByBirthDateEarlierThan(new DateTime(2000, 1, 1)));
            */
            /*通过不同委托，实现不同查询*/
            StudentUi.Display
                ("查找名为李乐健的学生"
				, im18.Students.FindBy
                    (StudentService.FindByName, "李乐健"));															//通过方法名直接创建委托实例；
            StudentUi.Display
                ("查找男生"
                , im18.Students.FindBy
                    (StudentService.FindByGender, Gender.MALE));
            StudentUi.Display
                ("查找生日早于2000年的学生"
                , im18.Students.FindBy
                    (StudentService.FindByBirthDateEarlierThan, new DateTime(2000, 1, 1)));
            /*通过λ表达式，实现不同查询或操作*/
            StudentUi.Display
                ("查找姓李的学生"
                , im18.Students.Find
                    ((s) => { return s.Name.Substring(0, 1) == "李"; }));                                           //通过Lambda表达式实现匿名方法，进而创建委托实例；编译器将从委托中的方法签名获取返回类型、参数类型；
            StudentUi.Display
                ("查找男生"
                , im18.Students.Find
                    (s => { return s.Gender == Gender.MALE; }));                                                    //若只有1个参数，可省略括号；
            StudentUi.Display
                ("查找生于2000年上半年的学生"
                , im18.Students.Find
                    (s => s.BirthDate.Year == 2000 && s.BirthDate.Month <= 6));                                     //单语句可省略{ return ; }；
            StudentUi.Display
                ("将所有男生改为女性"
                , im18.Students
                    .Find(s => s.Gender == Gender.MALE)
                    .Modify(s => s.Gender = Gender.FEMALE));
            Read();
        }
    }
}
