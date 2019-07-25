using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
    {
        static void Main()
        {
            Student[] students =
            {
                new Student("3180707001","周林好")
                ,new Student("3180707002","林钦妹")
                ,new Student("3180707003","胡方珍")
                ,new Student("3180707004","谢永成")
                ,new Student("3180707005","龙禹吉")
                ,new Student("3180707006","陈雯婷")
                ,new Student("3180707007","李乐健")
                ,new Student("3180707008","李志杰")
                ,new Student("3180707009","刘燕婷")
                ,new Student("31807070010","梁婷")
            };
            int pageSize = 3, pageNumber = 4;
            Student[] currentPageStudents = 
                PagingService.GetPage(students, pageSize, pageNumber);          //调用泛型方法；泛型方法可通过参数推断类型，无需再指定类型；
			WriteLine($"第{pageNumber}页：");
            foreach (Student student in currentPageStudents)
            {
				WriteLine($"学号：{student.Number,-15}姓名：{student.Name}");
            }
            Read();
        }
    }
}
