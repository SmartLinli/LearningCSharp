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
