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
                new Student("3180707001", "周林好")
                ,new Student("3180707002", "林钦妹")
                ,new Student("3180707003", "胡方珍")
                ,new Student("3180707004", "谢永成")
                ,new Student("3180707005", "龙禹吉")
                ,new Student("3180707006", "陈雯婷")
                ,new Student("3180707007", "李乐健")
                ,new Student("3180707008", "李志杰")
                ,new Student("3180707009", "刘燕婷")
                ,new Student("3180707010", "梁婷") 
            };
            Class im18 = new Class("18信管");
            im18.AddStudents(students);
            /*遍历班级中的学生；*/
            foreach (Student student in im18)                                       //使用foreach语句（只读地）访问提供了枚举器的类；但此处循环变量的类型无法使用var；
            {
                WriteLine($"{student.Number,-12}{student.Name}");
            }
            Read();
        }
    }
}
