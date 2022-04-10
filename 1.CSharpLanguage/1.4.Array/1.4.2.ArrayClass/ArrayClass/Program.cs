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
                new Student("3210707001", "田杰红"),
                new Student("3210707002", "刘兰"),
                new Student("3210707003", "吴争宇"),
                new Student("3210707004", "廖丽珍"),
                new Student("3210707005", "王诗琴")
            };
			/*定义班级；*/
			Class im21 = new Class("21信管");
            im21.AddStudents(students);
			Student[] newStudents =
			{
                new Student("3210707006", "罗清香"),
                new Student("3210707007", "谢晓丹"),
                new Student("3210707008", "刘浩雄"),                                  
                new Student("3210707009", "程琨耀"),
                //new Student("3210707010", "李健铭")                                    //班级对象的学生属性数组的长度将增长为10，但非空元素个数将为9；
            };
            im21.AddStudents(newStudents);
			/*排序；*/
			Array.Sort(im21.Students);                                                  //调用Array类的Sort静态方法，对数组进行冒泡排序，该数组的元素所属类还需实现IComparable接口；
            Array.Sort                                                                  //调用Sort方法的另一重载，实现更多排序选项；该方法还需一个实现了IComparer<>的类作为参数，用于实现更多排序选项；
                (im21.Students, new StudentComparer(StudentComparerType.NAME)); 
            /*显示排序结果；*/
            foreach (Student student in im21.Students)                                  
			{
                if (student is null)                                                    //foreach无法跳过空值元素，若不加以判断可能导致异常；
                    continue;
                WriteLine($"{student.Number,-12}{student.Name}");
			}
			Read();
		}
	}
}
