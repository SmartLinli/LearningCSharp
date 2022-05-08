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
                    new Student("3210707001", "田杰红", Gender.FEMALE),
                    new Student("3210707002", "刘兰", Gender.FEMALE),
                    new Student("3210707003", "吴争宇", Gender.MALE),
                    new Student("3210707004", "廖丽珍", Gender.FEMALE),
                    new Student("3210707005", "王诗琴", Gender.FEMALE),
                    new Student("3210708001", "唐昆", Gender.MALE),
                    new Student("3210708002", "吴诗怡", Gender.FEMALE),
                    new Student("3210708003", "陈樱", Gender.FEMALE)
                }
				, students2 = new HashSet<Student>()
				{
                    new Student("3210707004", "廖丽珍", Gender.MALE),
                    new Student("3210707005", "王诗琴", Gender.FEMALE),
                    new Student("3210707006", "罗清香", Gender.MALE),
                    new Student("3210708002", "吴诗怡", Gender.FEMALE),
                    new Student("3210708003", "陈樱", Gender.FEMALE),
                    new Student("3210708004", "郑凯莉", Gender.FEMALE),
                    new Student("3210708005", "王富玉", Gender.MALE),
                }
				, students3 = new HashSet<Student>()
				{
					new Student("3210707006", "罗清香", Gender.FEMALE)
					, new Student("3210708002", "吴诗怡", Gender.FEMALE)
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
