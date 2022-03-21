using static System.Console;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
    class Program
    {
        static void Main()
        {
            Student[] newStudents =
            {
                new Student("3210707001", "田杰红"),
                new Student("3210707002", "胡羽心"),
                new Student("3210707003", "吴争宇"),
                new Student("3210707004", "廖丽珍"),
                new Student("3210707005", "王诗琴")
            };
            Class im21 = new Class("21信管");
            im21 += newStudents;
            /*查找学生*/
            WriteLine($"查得学生{im21["3210707001"].Name}。");                      //通过索引器获取数组元素；
            /*修改学生*/
            im21["3210707002"].Name = "刘兰";                                      //通过索引器获取数组元素，并修改其属性；             
            WriteLine($"学生已更名为{im21["3210707002"].Name}。");
            /*添加学生*/
            im21["3210707006"] = new Student("3210707006", "罗清香");              //通过索引器对数组元素赋值；
            WriteLine($"新增学生{im21["3210707006"].Name}。");
            Read();
        }
    }
}
