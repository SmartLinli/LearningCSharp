using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
    {
        static void Main()
        {
            Student[] students =
            {
                new Student("3220707001", "曾羽"),
                new Student("3220707002", "纪凝"),
                new Student("3220707003", "宋明杰"),
                new Student("3220707004", "温歆滢"),
                new Student("3220707005", "连云飞"),
                new Student("3220707006", "张吉恒煊"),
                new Student("3220707007", "徐思亮"),
                new Student("3220707008", "林艺玲"),                                  
                new Student("3220707009", "张君英"),
                new Student("3220707010", "张昕楠")
            };
            int pageSize = 3, pageNumber = 4;
            Student[] currentPageStudents = 
                students.GetPage(pageSize, pageNumber);                         //调用泛型方法；泛型方法可通过参数推断类型，无需再指定类型；
			WriteLine($"第{pageNumber}页：");
            foreach (Student student in currentPageStudents)
            {
				WriteLine($"学号：{student.Number,-15}姓名：{student.Name}");
            }
            Read();
        }
    }
}
