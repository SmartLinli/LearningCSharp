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
				new Student("3180707001", "周林好")
				,new Student("3180707002", "林钦妹")
				,new Student("3180707003", "胡方珍")
				,new Student("3180707004", "谢永成")
				,new Student("3180707005", "龙禹吉")
			};
			/*定义班级；*/
			Class im18 = new Class("18信管");
			im18.AddStudents(students);
			Student[] newStudents =
			{
				new Student("3180707006", "陈雯婷")
				,new Student("3180707007", "李乐健")
				,new Student("3180707008", "李志杰")
				,new Student("3180707009", "刘燕婷")
				,new Student("3180707010", "梁婷")
			};
			im18.AddStudents(newStudents);
			/*排序；*/
			Array.Sort(im18.Students);                                                  //调用Array类的Sort静态方法，对数组进行冒泡排序，该数组还需实现IComparable接口；
			Array.Sort                                                                  //调用Sort方法的另一重载，实现更多排序选项；该方法还需一个实现了IComparer<>的类作为参数，用于实现更多排序选项；
				(im18.Students, new StudentComparer(StudentComparer.CompareType.NAME));
			/*显示排序结果；*/
			foreach (Student student in im18.Students)
			{
				WriteLine($"{student.Number,-12}{student.Name}");
			}
			Read();
		}
	}
}
