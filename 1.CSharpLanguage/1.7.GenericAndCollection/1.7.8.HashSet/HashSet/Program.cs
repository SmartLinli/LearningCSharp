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
                    new Student("3220707001", "曾羽", Gender.MALE),
                    new Student("3220707002", "纪凝", Gender.MALE),
                    new Student("3220707003", "宋明杰", Gender.MALE),
                    new Student("3220707004", "温歆滢", Gender.FEMALE),
                    new Student("3220707005", "连云飞", Gender.MALE),
                    new Student("3220708001", "邱旭", Gender.MALE),
                    new Student("3220708002", "林珑", Gender.FEMALE),
                    new Student("3220708003", "钟秋婷", Gender.FEMALE)
                }
				, students2 = new HashSet<Student>()
				{
                    new Student("3220707004", "温歆滢", Gender.FEMALE),
                    new Student("3220707005", "连云飞", Gender.MALE),
                    new Student("3220707006", "张吉恒煊", Gender.MALE),
                    new Student("3220708002", "林珑", Gender.FEMALE),
                    new Student("3220708003", "钟秋婷", Gender.FEMALE),
                    new Student("3220708004", "王钰芬", Gender.FEMALE),
                    new Student("3220708005", "简丹丹", Gender.FEMALE),
                }
				, students3 = new HashSet<Student>()
				{
					new Student("3220707006", "张吉恒煊", Gender.MALE)
					, new Student("3220708002", "林珑", Gender.FEMALE)
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
