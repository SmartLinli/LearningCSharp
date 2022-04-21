using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
    {
        static void Main()
        {
            Student[] students =
            {
                new Student("3210707001", "田杰红"),
                new Student("3210707002", "刘兰"),
                new Student("3210707003", "吴争宇"),
                new Student("3210707004", "廖丽珍"),
                new Student("3210707005", "王诗琴"),
                new Student("3210707006", "罗清香"),
                new Student("3210707007", "谢晓丹"),
                new Student("3210707008", "刘浩雄"),
                new Student("3210707009", "程琨耀"),
                new Student("3210707010", "李健铭")
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
