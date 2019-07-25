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
				new Student("3180707001", "周林好", Gender.FEMALE, new DateTime(2000, 4, 17))
				, new Student("3180707002", "林钦妹", Gender.FEMALE, new DateTime(1999, 10, 18))
				, new Student("3180707003", "胡方珍", Gender.FEMALE, new DateTime(2000, 1, 22))
				, new Student("3180707004", "谢永成", Gender.MALE, new DateTime(2000, 3, 2))
				, new Student("3180707005", "龙禹吉", Gender.FEMALE, new DateTime(1999, 8, 10))
				, new Student("3180707006", "陈雯婷", Gender.FEMALE, new DateTime(2000, 8, 24))
				, new Student("3180707007", "李乐健", Gender.MALE, new DateTime(2000, 1, 10))
				, new Student("3180707008", "李志杰", Gender.MALE, new DateTime(2001, 1, 14))
				, new Student("3180707009", "刘燕婷", Gender.FEMALE, new DateTime(2000, 9, 28))
				, new Student("3180707010", "梁婷", Gender.FEMALE, new DateTime(1999, 6, 12))
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
