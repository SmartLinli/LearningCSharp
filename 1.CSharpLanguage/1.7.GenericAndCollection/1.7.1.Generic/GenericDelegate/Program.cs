using System;
using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
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

			StudentUi.Display
				("查找年龄最小的学生",
				 im22.Students.Max(s => s.BirthDate));
			StudentUi.Display
				("查找姓李的学生",
				 im22.Students.Find(s => s.Name.Substring(0, 1) == "张"));
			WriteLine
				($"\n统计姓李的学生人数：{im22.Students.Count(s => s.Name.Substring(0, 1) == "张")}人");
			StudentUi.Display
				("将所有学生性别改为女性",
				 im22.Students.Modify(s => s.Gender = Gender.FEMALE));
			StudentUi.Display
				("对所有学生按照年龄由大到小排序",
				 im22.Students.Sort((s, s2) => s.BirthDate.CompareTo(s2.BirthDate)));
			Read();
		}
	}
}
