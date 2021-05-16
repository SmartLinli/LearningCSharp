using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
	class Program
	{
		static void Main()
		{
			HashSet<Student>                                                                            //定义散列集；
				students = new HashSet<Student>()
				{
                    new Student("3200707001", "闭敏媛", Gender.FEMALE),
                    new Student("3200707002", "储艺", Gender.FEMALE),
                    new Student("3200707003", "胡江彬", Gender.FEMALE),
                    new Student("3200707004", "林金川", Gender.MALE),
                    new Student("3200707005", "王泉井", Gender.FEMALE),
                    new Student("3200708001", "陈静怡", Gender.FEMALE),
                    new Student("3200708002", "程黄朝", Gender.MALE),
                    new Student("3200708003", "金国燕", Gender.FEMALE)
                }
				, students2 = new HashSet<Student>()
				{
                    new Student("3200707004", "林金川", Gender.MALE),
                    new Student("3200707005", "王泉井", Gender.FEMALE),
                    new Student("3200707006", "刘伯铭", Gender.MALE),
                    new Student("3200708002", "程黄朝", Gender.MALE),
                    new Student("3200708003", "金国燕", Gender.FEMALE),
                    new Student("3200708004", "李毅", Gender.FEMALE),
                    new Student("3200708005", "李成芳", Gender.FEMALE),
                }
				, students3 = new HashSet<Student>()
				{
					new Student("3200707006", "刘伯铭", Gender.MALE)
					, new Student("3200708002", "程黄朝", Gender.MALE)
				};
			WriteLine("差集：");
			students.Except(students2).ToList().ForEach												//调用Except泛型方法获取2个集的差集；散列集可转为列表，调用ForEach方法迭代访问各元素；
				(s => WriteLine($"学号：{s.Number,-15}姓名：{s.Name,-5}\t性别：{s.Gender}"));
			WriteLine("交集：");
			students.Intersect(students2).ToList().ForEach											//调用Intersect泛型方法获取2个集的差集；
				(s => WriteLine($"学号：{s.Number,-15}姓名：{s.Name,-5}\t性别：{s.Gender}"));
			WriteLine("并集：");
			students.Union(students2).ToList().ForEach												//调用Union泛型方法获取2个集的并集；
				(s => WriteLine($"学号：{s.Number,-15}姓名：{s.Name,-5}\t性别：{s.Gender}"));
			WriteLine
				($"students3{(students3.IsSubsetOf(students2) ? "" : "不")}是students2的子集。");     //调用IsSubsetOf方法判断是否子集；
			WriteLine
				($"students2{(students2.IsSupersetOf(students3) ? "" : "不")}是students3的超集。");   //调用IsSupersetOf方法判断是否超集；
			Read();
		}
	}
}
