using static System.Console;

namespace SmartLin.LearningCSharp.Array
{
	class Program
    {
        static void Main()
        {
            /*定义学生、班级；*/
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
            Class im21 = new Class("21信管");
            im21.AddStudents(students);
            /*遍历班级中的学生；*/
            foreach (Student student in im21)                                           //使用foreach语句（只读地）访问提供了枚举器的类；但此处循环变量的类型无法使用var；
            {
                WriteLine($"{student.Number,-12}{student.Name}");
            }
            Read();
        }
    }
}
