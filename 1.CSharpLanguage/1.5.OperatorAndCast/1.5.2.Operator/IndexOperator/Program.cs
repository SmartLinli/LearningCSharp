using static System.Console;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
    class Program
    {
        static void Main()
        {
            Student[] newStudents =
            {
                new Student("3220707001", "曾羽"),
                new Student("3220707002", "陈希彦"),
                new Student("3220707003", "宋明杰"),
                new Student("3220707004", "温歆滢"),
                new Student("3220707005", "连云飞")
            };
            Class im22 = new Class("22信管");
            im22 += newStudents;
            /*查找学生*/
            WriteLine($"查得学生{im22["3220707001"].Name}。");                      //通过索引器获取数组元素；
            /*修改学生*/
            im22["3220707002"].Name = "纪凝";                                     //通过索引器获取数组元素，并修改其属性；             
            WriteLine($"学生已更名为{im22["3220707002"].Name}。");
            /*添加学生*/
            im22["3220707006"] = new Student("3220707006", "张吉恒煊");              //通过索引器对数组元素赋值；
            WriteLine($"新增学生{im22["3220707006"].Name}。");
            Read();
        }
    }
}
