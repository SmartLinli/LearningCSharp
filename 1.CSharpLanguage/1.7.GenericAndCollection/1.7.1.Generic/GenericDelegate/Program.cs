using System;
using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
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

			StudentUi.Display
				("查找年龄最小的学生"
				, im21.Students.Max(s => s.BirthDate));
			StudentUi.Display
				("查找姓李的学生"
				, im21.Students.Find(s => s.Name.Substring(0, 1) == "李"));
			WriteLine
				($"\n统计姓李的学生人数：{im21.Students.Count(s => s.Name.Substring(0, 1) == "李")}人");
			StudentUi.Display
				("将所有学生性别改为女性"
				, im21.Students.Modify(s => s.Gender = Gender.FEMALE));
			StudentUi.Display
				("对所有学生按照年龄由大到小排序"
				, im21.Students.Sort((s, s2) => s.BirthDate.CompareTo(s2.BirthDate)));
			Read();
		}
	}
}
