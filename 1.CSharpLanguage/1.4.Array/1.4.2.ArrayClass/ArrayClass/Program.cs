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
                new Student("3220707001", "曾羽"),
                new Student("3220707002", "纪凝"),
                new Student("3220707003", "宋明杰"),
                new Student("3220707004", "温歆滢"),
                new Student("3220707005", "连云飞")
            };
			/*定义班级；*/
			Class im22 = new Class("22信管");
            im22.AddStudents(students);
			Student[] newStudents =
			{
                new Student("3220707006", "张吉恒煊"),
                new Student("3220707007", "徐思亮"),
                new Student("3220707008", "林艺玲"),                                  
                new Student("3220707009", "张君英"),
                //new Student("3220707010", "张昕楠")                                    //班级对象的学生属性数组的长度将增长为10，但非空元素个数将为9；
            };
            im22.AddStudents(newStudents);
			/*排序；*/
			Array.Sort(im22.Students);                                                  //调用Array类的Sort静态方法，对数组进行冒泡排序，该数组的元素所属类还需实现IComparable接口；
            Array.Sort                                                                  //调用Sort方法的另一重载，实现更多排序选项；该方法还需一个实现了IComparer<>的类作为参数，用于实现更多排序选项；
                (im22.Students, new StudentComparer(StudentComparerType.NAME)); 
            /*显示排序结果；*/
            foreach (Student student in im22.Students)                                  
			{
                if (student is null)                                                    //foreach无法跳过空值元素，若不加以判断可能导致异常；
                    continue;
                WriteLine($"{student.Number,-12}{student.Name}");
			}
			Read();
		}
	}
}
