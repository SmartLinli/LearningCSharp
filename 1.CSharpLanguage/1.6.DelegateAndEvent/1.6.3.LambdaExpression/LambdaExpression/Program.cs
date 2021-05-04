using System;
using static System.Console;

namespace SmartLin.LearningCSharp.DelegateAndEvent
{
	class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im20 = new Class(infomationManagement, 2020);
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
            im20.Students = students;
            /*通过不同方法，实现不同查询；
            StudentUi.Display
                ("查找学号为3200707001的学生"
                , im20.Students.FindByNumber("3200707001"));
            StudentUi.Display
                ("查找名为闭敏媛的学生"
                , im20.Students.FindByName("闭敏媛"));
            StudentUi.Display
                ("查找男生"
                , im20.Students.FindByGender(Gender.MALE));
            StudentUi.Display
                ("查找生日早于2002年的学生"
                , im20.Students.FindByBirthDateEarlierThan(new DateTime(2002, 1, 1)));
            */
            /*通过不同委托，实现不同查询*/
            StudentUi.Display
                ("查找名为闭敏媛的学生"
                , im20.Students.FindBy
                    (StudentService.FindByName, "闭敏媛"));															//通过方法名直接创建委托实例；
            StudentUi.Display
                ("查找男生"
                , im20.Students.FindBy
                    (StudentService.FindByGender, Gender.MALE));
            StudentUi.Display
                ("查找生日早于2002年的学生"
                , im20.Students.FindBy
                    (StudentService.FindByBirthDateEarlierThan, new DateTime(2002, 1, 1)));
            /*通过λ表达式，实现不同查询或操作*/
            StudentUi.Display
                ("查找姓王的学生"
                , im20.Students.Find
                    ((s) => { return s.Name.Substring(0, 1) == "王"; }));                                           //通过Lambda表达式实现匿名方法，进而创建委托实例；编译器将从委托中的方法签名获取返回类型、参数类型；
            StudentUi.Display
                ("查找男生"
                , im20.Students.Find
                    (s => { return s.Gender == Gender.MALE; }));                                                    //若只有1个参数，可省略括号；
            StudentUi.Display
                ("查找生于2002年上半年的学生"
                , im20.Students.Find
                    (s => s.BirthDate.Year == 2002 && s.BirthDate.Month <= 6));                                     //单语句可省略{ return ; }；
            StudentUi.Display
                ("将所有男生改为女性"
                , im20.Students
                    .Find(s => s.Gender == Gender.MALE)
                    .Modify(s => s.Gender = Gender.FEMALE));
            Read();
        }
    }
}
