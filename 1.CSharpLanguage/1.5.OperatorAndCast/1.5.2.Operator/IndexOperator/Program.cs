using static System.Console;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
    class Program
    {
        static void Main()
        {
            Student[] newStudents =                                                    
            {
                new Student("3200707001", "闭敏媛"),
                new Student("3200707002", "江紫燕"),
                new Student("3200707003", "胡江彬"),
                new Student("3200707004", "林金川"),
                new Student("3200707005", "王泉井")
            };
            Class im20 = new Class("20信管");
            im20 += newStudents;
			/*查找学生*/
			WriteLine
				($"查得学生{im20["3200707001"].Name}。");                          //通过索引器获取数组元素；
            /*修改学生*/
            im20["3200707002"].Name = "储艺";                                      //通过索引器获取数组元素，并修改其属性；             
            WriteLine
                ($"学生已更名为{im20["3200707002"].Name}。");
            /*添加学生*/
            im20["3200707006"] = new Student("3200707006", "刘伯铭");              //通过索引器对数组元素赋值；
			WriteLine
				($"新增学生{im20["3200707006"].Name}。");
            Read();
        }
    }
}
