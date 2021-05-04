using System;
using static System.Console;

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
			im18.Students = students;

			StudentUi.Display
				("查找年龄最大的学生"
				, im18.Students.Max
					((s, s2) => s.BirthDate <= s2.BirthDate));
			StudentUi.Display
				("查找姓李的学生"
				, im18.Students.Find
					(s => s.Name.Substring(0, 1) == "李"));
			WriteLine
				($"\n查找姓李的学生人数：{im18.Students.Count(s => s.Name.Substring(0, 1) == "李")}人");
			StudentUi.Display
				("将所有学生性别改为女性"
				, im18.Students.Modify
					(s => s.Gender = Gender.FEMALE));
			StudentUi.Display
				("对所有学生按照年龄由大到小排序"
				, im18.Students.Sort
					((s, s2) => s.BirthDate.CompareTo(s2.BirthDate)));
			Read();
		}
	}
}
