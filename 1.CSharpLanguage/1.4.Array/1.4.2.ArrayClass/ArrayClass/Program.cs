using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ArrayClass
{
	class Program
	{
		static void Main()
		{
			/*定义学生；*/
			Student[] students =
			{
                new Student("3200707001", "闭敏媛"),
                new Student("3200707002", "储艺"),
                new Student("3200707003", "胡江彬"),
                new Student("3200707004", "林金川"),
                new Student("3200707005", "王泉井")
            };
			/*定义班级；*/
			Class im20 = new Class("20信管");
            im20.AddStudents(students);
			Student[] newStudents =
			{
                new Student("3200707006", "刘伯铭"),
                new Student("3200707007", "王子驭"),
                new Student("3200707009", "郑喻文"),
                new Student("3200707010", "朱素清"),
                new Student("3200707011", "何延斌")
            };
            im20.AddStudents(newStudents);
			/*排序；*/
			Array.Sort(im20.Students);                                                  //调用Array类的Sort静态方法，对数组进行冒泡排序，该数组还需实现IComparable接口；
			Array.Sort                                                                  //调用Sort方法的另一重载，实现更多排序选项；该方法还需一个实现了IComparer<>的类作为参数，用于实现更多排序选项；
				(im20.Students, new StudentComparer(StudentComparer.CompareType.NAME));
			/*显示排序结果；*/
			foreach (Student student in im20.Students)
			{
				WriteLine($"{student.Number,-12}{student.Name}");
			}
			Read();
		}
	}
}
