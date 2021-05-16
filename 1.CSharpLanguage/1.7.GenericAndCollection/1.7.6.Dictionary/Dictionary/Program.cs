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
                new Student("3200707001", "闭敏媛", Gender.FEMALE, new DateTime(2001, 7, 21)),
                new Student("3200707002", "储艺", Gender.FEMALE, new DateTime(2001, 7, 12)),
                new Student("3200707003", "胡江彬", Gender.FEMALE, new DateTime(2000, 9, 6)),
                new Student("3200707004", "林金川", Gender.MALE, new DateTime(2001, 7, 18)),
                new Student("3200707005", "王泉井", Gender.FEMALE, new DateTime(2000, 10, 12)),
                new Student("3200707006", "刘伯铭", Gender.FEMALE, new DateTime(2002, 2, 17)),
                new Student("3200707007", "王子驭", Gender.MALE, new DateTime(2002, 7, 29)),
                new Student("3200707009", "郑喻文", Gender.MALE, new DateTime(2002, 5, 11)),
                new Student("3200707010", "朱素清", Gender.FEMALE, new DateTime(2002, 5, 17)),
                new Student("3200707011", "何延斌", Gender.FEMALE, new DateTime(2002, 12, 17))
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
