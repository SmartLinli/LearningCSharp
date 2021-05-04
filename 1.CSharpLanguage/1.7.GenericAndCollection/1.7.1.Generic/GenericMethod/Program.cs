using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
    {
        static void Main()
        {
            Student[] students =
            {
                new Student("3200707001", "闭敏媛"),
                new Student("3200707002", "储艺"),
                new Student("3200707003", "胡江彬"),
                new Student("3200707004", "林金川"),
                new Student("3200707005", "王泉井"),
                new Student("3200707006", "刘伯铭"),
                new Student("3200707007", "王子驭"),
                new Student("3200707009", "郑喻文"),
                new Student("3200707010", "朱素清"),
                new Student("3200707011", "何延斌")
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
