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
                new Student("3220707001", "曾羽"),
                new Student("3220707002", "纪凝"),
                new Student("3220707003", "宋明杰"),
                new Student("3220707004", "温歆滢"),
                new Student("3220707005", "连云飞"),
                new Student("3210707006", "张吉恒煊"),
                new Student("3210707007", "徐思亮"),
                new Student("3210707008", "林艺玲"),                                  
                new Student("3210707009", "张君英"),
                new Student("3210707010", "张昕楠")
            };
            Class im22 = new Class("22信管");
            im22.AddStudents(students);
            /*遍历班级中的学生；*/
            foreach (Student student in im22)                                           //使用foreach语句（只读地）访问提供了枚举器的类；但此处循环变量的类型无法使用var；
            {
                WriteLine($"{student.Number,-12}{student.Name}");
            }
            Read();
        }
    }
}
