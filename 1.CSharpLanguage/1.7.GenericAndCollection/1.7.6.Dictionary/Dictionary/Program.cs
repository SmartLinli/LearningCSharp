using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
	{
		static void Main()
		{
			List<Student> studentsList = new List<Student>()                                                //定义泛型列表对象；
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
			Dictionary<string, Student> students = studentsList.ToDictionary(s => s.Number);                //字典仅提供Add方法，仅能逐一添加单个元素；故使用列表提供的ToDictionary方法将列表转为字典，并在参数中指定键；
			while (true)
			{
				WriteLine("请输入要查找的学号：");
				var input = ReadLine();
				if (students.TryGetValue(input, out Student student))                                       //调用字典的TryGetValue方法，返回是否存在该键，并将相应元素输出至指定参数；
				{
					WriteLine($"学号：{student.Number,-15}姓名：{student.Name,-5}\n");
				}
				else
				{
					WriteLine("查无此人！\n");
				}
			}
		}
	}
}
