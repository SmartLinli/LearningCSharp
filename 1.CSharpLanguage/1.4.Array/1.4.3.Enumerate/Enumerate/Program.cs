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
            Class im20 = new Class("20信管");
            im20.AddStudents(students);
            /*遍历班级中的学生；*/
            foreach (Student student in im20)                                       //使用foreach语句（只读地）访问提供了枚举器的类；但此处循环变量的类型无法使用var；
            {
                WriteLine($"{student.Number,-12}{student.Name}");
            }
            Read();
        }
    }
}
